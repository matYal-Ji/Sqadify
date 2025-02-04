using Squadify.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Squadify.CustomControls
{
    public partial class PlayerViewControl : UserControl
    {
        BindingSource _bindingSource;

        public PlayerViewControl()
        {
            InitializeComponent();
        }

        public PlayerViewControl(BindingSource source)
        {
            InitializeComponent();
            _bindingSource = source;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            lblEmployeeName.DataBindings.Add(nameof(TextBox.Text), _bindingSource, nameof(Player.Name));
            lblAge.DataBindings.Add(nameof(TextBox.Text), _bindingSource, nameof(Player.Age));
            lblGender.DataBindings.Add(nameof(TextBox.Text), _bindingSource, nameof(Player.Gender));

            var binding = lblSkills.DataBindings.Add(nameof(TextBox.Text), _bindingSource, nameof(Player.Skills));
            binding.Format += (s, e) =>
            {
                if (e.Value is IEnumerable<string> skills)
                {
                    e.Value = string.Join(", ", skills);
                }
            };
        }
    }
}
