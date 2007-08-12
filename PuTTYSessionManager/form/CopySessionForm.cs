/* 
 * Copyright (C) 2006,2007 David Riseley 
 *
 * This program is free software; you can redistribute it and/or
 * modify it under the terms of the GNU General Public License
 * as published by the Free Software Foundation; either version 2
 * of the License, or (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using uk.org.riseley.puttySessionManager.model;
using uk.org.riseley.puttySessionManager.controller;

namespace uk.org.riseley.puttySessionManager.form
{
    public partial class CopySessionForm : SessionManagementForm
    {
        private Form parentWindow;
        private CopySessionRequest csr;
        private Dictionary<CopySessionRequest.AttribGroups, CheckBox> checkboxDictionary;

        public CopySessionForm(Form parent)
            : base()
        {
            parentWindow = parent;
            InitializeComponent();
            SessionController.SessionsRefreshedEventHandler scHandler = new SessionController.SessionsRefreshedEventHandler(this.SessionsRefreshed);
            sc.SessionsRefreshed += scHandler;
            csr = new CopySessionRequest();
            tagCheckboxes();
            tagRadioButtons();
            createDictonary();
            copyAllRadioButton.Checked = true;
        }

        private void tagCheckboxes()
        {
            coloursCheckBox.Tag = CopySessionRequest.AttribGroups.COLOURS;
            userNameCheckBox.Tag = CopySessionRequest.AttribGroups.DEFAULT_USERNAME;
            scrollBackCheckBox.Tag = CopySessionRequest.AttribGroups.SCROLLBACK;
            fontCheckBox.Tag = CopySessionRequest.AttribGroups.FONT;
            hostnameCheckBox.Tag = CopySessionRequest.AttribGroups.HOSTNAME;
            protocoCheckBox.Tag = CopySessionRequest.AttribGroups.PROTOCOL_PORT;
            portForwardCheckBox.Tag = CopySessionRequest.AttribGroups.SSH_PORT_FORWARDS;
            keepalivesCheckBox.Tag = CopySessionRequest.AttribGroups.KEEP_ALIVES;
            selectionCheckBox.Tag = CopySessionRequest.AttribGroups.SELECTION_CHARS;
            folderCheckBox.Tag = CopySessionRequest.AttribGroups.SESSION_FOLDER;
        }

        private void tagRadioButtons()
        {
            copyAllRadioButton.Tag = CopySessionRequest.CopySessionOptions.COPY_ALL;
            includeRadioButton.Tag = CopySessionRequest.CopySessionOptions.COPY_INCLUDE;
            excludeRadioButton.Tag = CopySessionRequest.CopySessionOptions.COPY_EXCLUDE;
        }

        private void createDictonary()
        {
            checkboxDictionary = new Dictionary<CopySessionRequest.AttribGroups, CheckBox>();
            checkboxDictionary.Add((CopySessionRequest.AttribGroups)coloursCheckBox.Tag, coloursCheckBox);
            checkboxDictionary.Add((CopySessionRequest.AttribGroups)userNameCheckBox.Tag, userNameCheckBox);
            checkboxDictionary.Add((CopySessionRequest.AttribGroups)scrollBackCheckBox.Tag, scrollBackCheckBox);
            checkboxDictionary.Add((CopySessionRequest.AttribGroups)fontCheckBox.Tag, fontCheckBox);
            checkboxDictionary.Add((CopySessionRequest.AttribGroups)hostnameCheckBox.Tag, hostnameCheckBox);
            checkboxDictionary.Add((CopySessionRequest.AttribGroups)protocoCheckBox.Tag, protocoCheckBox);
            checkboxDictionary.Add((CopySessionRequest.AttribGroups)portForwardCheckBox.Tag, portForwardCheckBox);
            checkboxDictionary.Add((CopySessionRequest.AttribGroups)keepalivesCheckBox.Tag, keepalivesCheckBox);
            checkboxDictionary.Add((CopySessionRequest.AttribGroups)selectionCheckBox.Tag, selectionCheckBox);
            checkboxDictionary.Add((CopySessionRequest.AttribGroups)folderCheckBox.Tag, folderCheckBox);
        }

        private void loadList()
        {
            sessionComboBox.Items.AddRange(sc.getSessionList().ToArray());
            Session s = sc.findDefaultSession(false);
            if (s != null)
            {
                sessionComboBox.SelectedItem = s;
                attributeListBox.Items.AddRange(sc.getSessionAttributes(s).ToArray());
                csr.SessionTemplate = s;
                csr.SelectedAttributes = getSelectedAttributes();
            }
        }

        private void clearList()
        {
            sessionComboBox.Items.Clear();
            attributeListBox.Items.Clear();
        }

        public void SessionsRefreshed(Object sender, EventArgs e)
        {
            clearList();
            loadList();
        }

        public CopySessionRequest getCopySessionRequest()
        {
            return csr;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (csr.TargetSessions.Count == 0)
            {
                MessageBox.Show("You must select some sessions to copy to!"
                    , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }

            if (csr.CopyOptions == CopySessionRequest.CopySessionOptions.COPY_INCLUDE
                && (csr.SelectedAttributes == null || csr.SelectedAttributes.Count == 0 ))
            {
                MessageBox.Show("You must select some attributes to copy!"
                   , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }

            if (csr.CopyOptions == CopySessionRequest.CopySessionOptions.COPY_INCLUDE
                && csr.selectionContainsHostname())
            {
                if (MessageBox.Show("You are going to overwrite the hostname on all your target sessions.\n" +
                          "Are you sure?"
                        , "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    DialogResult = DialogResult.None;
                    return;
                }
            }

            if (csr.CopyOptions == CopySessionRequest.CopySessionOptions.COPY_INCLUDE
                && csr.selectionContainsFolder())
            {
                if (MessageBox.Show("You are going to overwrite the folders on all your target sessions.\n" +
                          "Are you sure?"
                        , "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    DialogResult = DialogResult.None;
                    return;
                }
            }

            DialogResult dr = backupSessions(csr.TargetSessions);
            if (dr == DialogResult.Cancel)
            {
                DialogResult = DialogResult.None;
                return;
            }
            
            if (MessageBox.Show("Are you sure you want to copy attributes from " + csr.SessionTemplate.SessionDisplayText +
                                " to " + csr.TargetSessions.Count + " sessions?"
                    , "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool result = sc.copySessionAttributes(csr);
                if (result == false)
                    MessageBox.Show("Failed to copy session attributes - you may need to refresh the session list"
                    , "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    sc.invalidateSessionList(this, true);
            }
            else
            {
                DialogResult = DialogResult.None;
                return;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton) sender;
            if ( rb == copyAllRadioButton )
            {
                attributesGroupBox.Enabled = !(copyAllRadioButton.Checked);
            }

            if ( rb.Checked == true )
                csr.CopyOptions = (CopySessionRequest.CopySessionOptions)rb.Tag;
        }

        private void sessionComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Suspend redraw
            SuspendLayout();

            // Save the list of selected items
            string[] selectedItems = new string[attributeListBox.SelectedItems.Count];
            attributeListBox.SelectedItems.CopyTo(selectedItems, 0);

            // Clear the existing list
            attributeListBox.Items.Clear();

            // Import the attributes from the new selected session
            attributeListBox.Items.AddRange(sc.getSessionAttributes((Session)sessionComboBox.SelectedItem).ToArray());

            // Attempt to reselect the item
            foreach (string s in selectedItems)
            {
                attributeListBox.SelectedItems.Add(s);
            }

            // Update the list of selected attributes
            csr.SelectedAttributes = getSelectedAttributes();

            // Update the template session in the copy session request
            csr.SessionTemplate = (Session)sessionComboBox.SelectedItem;

            // Resume redraw
            ResumeLayout();

        }

        private void selectAllButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < attributeListBox.Items.Count; i++)
                attributeListBox.SelectedIndices.Add(i);
            csr.SelectedAttributes = getSelectedAttributes();
        }

        private void selectNoneButton_Click(object sender, EventArgs e)
        {
            attributeListBox.SelectedIndices.Clear();
            csr.SelectedAttributes = getSelectedAttributes();
        }

        private void invertButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < attributeListBox.Items.Count; i++)
            {
                if (attributeListBox.SelectedIndices.Contains(i))
                    attributeListBox.SelectedIndices.Remove(i);
                else
                    attributeListBox.SelectedIndices.Add(i);
            }
            csr.SelectedAttributes = getSelectedAttributes();
        }


        private List<string> getSelectedAttributes()
        {
            string[] selectedAttribs = new string[attributeListBox.SelectedItems.Count];
            attributeListBox.SelectedItems.CopyTo(selectedAttribs, 0);
            List<string> sl = new List<string>();
            sl.AddRange(selectedAttribs);
            return sl;
        }

        private void attributeListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            csr.SelectedAttributes = getSelectedAttributes();

            foreach (CheckBox cb in checkboxDictionary.Values)
            {
                cb.CheckState = csr.getGroupStatus((CopySessionRequest.AttribGroups)cb.Tag);
            }
        }

        private void checkBox_Click(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            bool buttonChecked = cb.Checked;

            // Figure out which attribute group the button is tagged with
            CopySessionRequest.AttribGroups ag = (CopySessionRequest.AttribGroups)cb.Tag;

            // Get the list of attributes associated with this group
            List<string> attribs = csr.getAttribs(ag);

            int index = -1;
            int attribCount = 0;

            // Foreach attribute in the list
            foreach (string s in attribs)
            {
                // Check if the attribute exists in the 
                // template session
                index = attributeListBox.Items.IndexOf(s);
                
                // If it does...
                if (index >= 0)
                {                    
                    if (buttonChecked == true)
                    {
                        // Add it to the selection
                        attributeListBox.SelectedIndices.Add(index);
                        attribCount++;
                    }
                    else if (buttonChecked == false)
                    {
                        // Remove it from the selection
                        attributeListBox.SelectedIndices.Remove(index);
                    }
                }
            }

            // If we have tried to check a box, but not found any
            // matching attributes , uncheck the box again.
            if (buttonChecked == true && attribCount == 0)
            {
                cb.Checked = false;
            }

            // Update the copy session request with the selected
            // attributes.
            csr.SelectedAttributes = getSelectedAttributes();
        }

        public void setTargetSessions(List<Session> targetSessions)
        {
            csr.TargetSessions = targetSessions;
        }       
    }
}