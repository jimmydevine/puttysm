/* 
 * Copyright (C) 2007,2011 David Riseley 
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

namespace uk.org.riseley.puttySessionManager.model
{
    /// <summary>
    /// A class that allows tree nodes to be sorted by folder and name
    /// </summary>
    public class SessionSorter : IComparer<Session>
    {
        /// <summary>
        /// Enumeration of different possible sort orders
        /// </summary>
        public enum SortOrder
        {
            FOLDER_FIRST  = 1,
            FOLDER_IGNORE = 0,
            FOLDER_LAST   = -1
        }

        /// <summary>
        /// The current sort order
        /// </summary>
        private int sortOrder;

        /// <summary>
        /// An alpha numeric comparator
        /// </summary>
        private AlphanumComparator.AlphanumComparator alphanumComparator;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="order">The sort order for this instance</param>
        public SessionSorter(SortOrder order)
        {
            sortOrder = (int)order;
            alphanumComparator = new AlphanumComparator.AlphanumComparator();
        }

        /// <summary>
        /// Method to compare the values of two tree
        /// nodes
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns> x less than    y = less than 0
        ///           x equal to     y = 0
        ///           x greater than y = greater than 0</returns>
        protected int compare(Session x, Session y)
        {
            if (x == null || y == null)
                throw new ArgumentException("Both arguments must be specified");

            if (x == null && y == null)
                return 0;
            else if (x == null && y != null)
                return -1 * sortOrder;
            else if (x != null && y == null)
                return 1 * sortOrder;
            else if (sortOrder == 0)
                return alphanumComparator.Compare(x.SessionDisplayText, y.SessionDisplayText);
            else if (x.IsFolder && !(y.IsFolder))
                return -1 * sortOrder;
            else if (!(x.IsFolder) && (y.IsFolder))
                return 1 * sortOrder;
            else
                return alphanumComparator.Compare(x.SessionDisplayText, y.SessionDisplayText);
        }

        #region IComparer Members

        int IComparer<Session>.Compare(Session x, Session y)
        {
            return compare(x, y);
        }

        #endregion
    }
}
