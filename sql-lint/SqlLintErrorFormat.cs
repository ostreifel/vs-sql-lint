using System.ComponentModel.Composition;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace sql_lint
{
    /// <summary>
    /// Defines an editor format for the SqlLintError type that has a purple background
    /// and is underlined.
    /// </summary>
    [Export(typeof(EditorFormatDefinition))]
    [ClassificationType(ClassificationTypeNames = "SqlLintError")]
    [Name("SqlLintError")]
    [UserVisible(true)] // This should be visible to the end user
    [Order(Before = Priority.Default)] // Set the priority to be after the default classifiers
    internal sealed class SqlLintErrorFormat : ClassificationFormatDefinition
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlLintErrorFormat"/> class.
        /// </summary>
        public SqlLintErrorFormat()
        {
            this.DisplayName = "SqlLintError"; // Human readable version of the name
            this.ForegroundColor = Colors.OrangeRed;
            this.TextDecorations = System.Windows.TextDecorations.Underline;
        }
    }
}
