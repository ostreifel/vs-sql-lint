using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace sql_lint
{
    /// <summary>
    /// Classification type definition export for SqlLintError
    /// </summary>
    internal static class SqlLintErrorClassificationDefinition
    {
        // This disables "The field is never used" compiler's warning. Justification: the field is used by MEF.
#pragma warning disable 169

        /// <summary>
        /// Defines the "SqlLintError" classification type.
        /// </summary>
        [Export(typeof(ClassificationTypeDefinition))]
        [Name("SqlLintError")]
        private static ClassificationTypeDefinition typeDefinition;

#pragma warning restore 169
    }
}
