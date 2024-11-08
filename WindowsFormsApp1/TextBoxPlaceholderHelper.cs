using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1.Helpers
{
    public static class TextBoxPlaceholderHelper
    {
        // Method to set placeholder text
        public static void SetPlaceholder(TextBox textBox, string placeholderText)
        {
            textBox.Text = placeholderText;
            textBox.ForeColor = Color.Gray;

            // Add event handlers for Enter and Leave events
            textBox.Enter += (sender, e) => ClearPlaceholder(textBox, placeholderText);
            textBox.Leave += (sender, e) => RestorePlaceholder(textBox, placeholderText);
        }

        // Method to clear placeholder text when user clicks inside the TextBox
        private static void ClearPlaceholder(TextBox textBox, string placeholderText)
        {
            if (textBox.Text == placeholderText)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        // Method to restore placeholder text if the TextBox is empty after losing focus
        private static void RestorePlaceholder(TextBox textBox, string placeholderText)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = Color.Gray;
            }
        }
    }
}
