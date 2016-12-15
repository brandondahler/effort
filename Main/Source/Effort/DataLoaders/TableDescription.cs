﻿// --------------------------------------------------------------------------------------------
// <copyright file="TableDescription.cs" company="Effort Team">
//     Copyright (C) Effort Team
//
//     Permission is hereby granted, free of charge, to any person obtaining a copy
//     of this software and associated documentation files (the "Software"), to deal
//     in the Software without restriction, including without limitation the rights
//     to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//     copies of the Software, and to permit persons to whom the Software is
//     furnished to do so, subject to the following conditions:
//
//     The above copyright notice and this permission notice shall be included in
//     all copies or substantial portions of the Software.
//
//     THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//     IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//     FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//     AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//     LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//     OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
//     THE SOFTWARE.
// </copyright>
// --------------------------------------------------------------------------------------------

namespace Effort.DataLoaders
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;

    /// <summary>
    ///     Stores the metadata of a table.
    /// </summary>
    public sealed class TableDescription
    {
        internal TableDescription(string schema, string name, IEnumerable<ColumnDescription> columns)
        {
            this.Name = name;
            this.Schema = schema;
            this.Columns = columns.ToList().AsReadOnly();
        }

        internal TableDescription(string name, IEnumerable<ColumnDescription> columns) : this(null, name, columns)
        {
        }

        /// <summary>
        ///     Gets the name of the table.
        /// </summary>
        /// <value>
        ///     The name of the table.
        /// </value>
        public string Name { get; private set; }


        /// <summary>
        ///     Gets the schema of the table.
        /// </summary>
        /// <value>
        ///     The schema of the table.
        /// </value>
        public string Schema { get; set; }

        /// <summary>
        ///     Gets the columns of the table.
        /// </summary>
        /// <value>
        ///     The columns of the table.
        /// </value>
        public ReadOnlyCollection<ColumnDescription> Columns { get; private set; }
    }
}
