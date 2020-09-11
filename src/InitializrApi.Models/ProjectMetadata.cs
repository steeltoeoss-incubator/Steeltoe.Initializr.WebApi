// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.

namespace Steeltoe.InitializrApi.Models
{
    /// <summary>
    /// A model of metadata used to describe the configuration of a project.
    /// </summary>
    public sealed class ProjectMetadata
    {
        /* ----------------------------------------------------------------- *
         * properties                                                        *
         * ----------------------------------------------------------------- */

        /// <summary>
        /// Gets or sets the project name.
        /// </summary>
        public Text Name { get; set; }

        /// <summary>
        /// Gets or sets the project description.
        /// </summary>
        public Text Description { get; set; }

        /// <summary>
        /// Gets or sets the project namespace.
        /// </summary>
        public Text Namespace { get; set; }

        /// <summary>
        /// Gets or sets the Steeltoe versions.
        /// </summary>
        public SingleSelectList SteeltoeVersion { get; set; }

        /// <summary>
        /// Gets or sets the DotNet frameworks.
        /// </summary>
        public SingleSelectList DotNetFramework { get; set; }

        /// <summary>
        /// Gets or sets the DotNet template types.
        /// </summary>
        public SingleSelectList DotNetTemplate { get; set; }

        /// <summary>
        /// Gets or sets the languages.
        /// </summary>
        public SingleSelectList Language { get; set; }

        /// <summary>
        /// Gets or sets the project archive mime type.
        /// </summary>
        public SingleSelectList ArchiveMimeType { get; set; }

        /// <summary>
        /// Gets or sets the project dependencies.
        /// </summary>
        public GroupList Dependencies { get; set; }

        /// <summary>
        /// HTML form text data.
        /// </summary>
        public class Text
        {
            /// <summary>
            /// Gets or sets the widget type.
            /// </summary>
            public string Type { get; set; } = "text";

            /// <summary>
            /// Gets or sets the default value.
            /// </summary>
            public string Default { get; set; }
        }

        /// <summary>
        /// Abstraction of an item in a list.
        /// </summary>
        public abstract class Item
        {
            /// <summary>
            /// Gets or sets the item ID.
            /// </summary>
            public string Id { get; set; }

            /// <summary>
            /// Gets or sets the item name.
            /// </summary>
            public string Name { get; set; }
        }

        /// <summary>
        /// Abstraction of a list of items.
        /// </summary>
        public abstract class ItemList
        {
            /// <summary>
            /// Gets or sets the widget type.
            /// </summary>
            public string Type { get; set; }
        }

        /// <summary>
        /// Abstraction of an item in a single select list.
        /// </summary>
        public class SelectItem : Item
        {
        }

        /// <summary>
        /// Abstraction of a list of items that has 1 and only 1 selected item.
        /// </summary>
        public class SingleSelectList : ItemList
        {
            /// <summary>
            /// Gets or sets the default selection.
            /// </summary>
            public string Default { get; set; }

            /// <summary>
            /// Gets or sets the list items.
            /// </summary>
            public SelectItem[] Values { get; set; }
        }

        /// <summary>
        /// Abstraction of an item in a group list.
        /// </summary>
        public class GroupItem : Item
        {
            /// <summary>
            /// Gets or sets the description.
            /// </summary>
            public string Description { get; set; }

            /// <summary>
            /// Gets or sets the Steeltoe version constraints.
            /// </summary>
            public string SteeltoeVersionRange { get; set; }
        }

        /// <summary>
        /// A grouping of items in a group item list.
        /// </summary>
        public class Group
        {
            /// <summary>
            /// Gets or sets the name.
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// Gets or sets the items.
            /// </summary>
            public GroupItem[] Values { get; set; }
        }

        /// <summary>
        /// Abstraction of a list of items that can have several selections.  The items are logical grouped.
        /// </summary>
        public class GroupList : ItemList
        {
            /// <summary>
            /// Gets or sets the default dependencies.
            /// </summary>
            public string Default { get; set; }

            /// <summary>
            /// Gets or sets the groups.
            /// </summary>
            public Group[] Values { get; set; }
        }
    }
}
