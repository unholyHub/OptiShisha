using System.Windows.Forms;

namespace ServerFormApplication
{
    static class FormFunctions
    {
        public static Form GetOpenedForm(string formName)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                {
                    return form;
                }
            }

            return new Form();
        }
    }
}
