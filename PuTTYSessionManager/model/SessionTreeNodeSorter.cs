/* 
 * Copyright (C) 2011 David Riseley 
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
using System.Collections;
using System.Windows.Forms;

namespace uk.org.riseley.puttySessionManager.model
{
    /// <summary>
    /// A class that allows tree nodes to be sorted by folder and name
    /// </summary>
    public class SessionTreeNodeSorter : SessionSorter, IComparer
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="order">The sort order for this instance</param>
        public SessionTreeNodeSorter(SortOrder order) : base(order)
        {
        }

        #region IComparer Members
        /// <summary>
        /// Method to compare the values of two tree nodes
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns> 
        /// x less    than y => less than 0
        /// x equal   to   y => 0
        /// x greater than y => greater than 0
        /// </returns>
        int IComparer.Compare(object x, object y)
        {
            TreeNode tx = x as TreeNode;
            TreeNode ty = y as TreeNode;

            if (x == null || y == null)
                throw new ArgumentException("Both arguments must be specified");

            Session sx = tx.Tag as Session;
            Session sy = ty.Tag as Session;

            return compare(sx, sy);
        }
        #endregion
    }
}
