using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Dashbord.Utilities {
	class Generics {
		public static int CheckedRadioButton(Panel panel, List<string> elements) => elements.IndexOf(panel.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text);

		public static void LoadComboBox(ComboBox comboBox, string attribute, string index, Func<DataTable> query) {
			DataTable dataTable = query();

			comboBox.DataSource = dataTable;
			comboBox.DisplayMember = attribute;
			comboBox.SelectedIndex = -1;
			comboBox.ValueMember = index;
		}

		public static void CleanFields(Form form) {
			foreach (var element in form.Controls) {
				switch (element) {
					case TextBox textBox:
						textBox.ResetText();
						break;
					case MaskedTextBox maskedTextBox:
						maskedTextBox.ResetText();
						break;
					case RadioButton radioButton:
						radioButton.Checked = false;
						break;
					case CheckBox checkBox:
						checkBox.Checked = false;
						break;
					case ComboBox comboBox:
						comboBox.SelectedValue = -1;
						break;
				}
			}
		}
	}
}
