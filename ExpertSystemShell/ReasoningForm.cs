using ExpertSystemShell.Model;

namespace ExpertSystemShell
{
    public partial class ReasoningForm : Form
    {
        private string fact;
        public ReasoningForm(bool isSuccess)
        {
            InitializeComponent();
            SetVariable();
            ListViewResizeColumns();
            var goal = Program.shell.memory.goal;
            fact = null;
            if (isSuccess && Program.shell.memory.usedRule.ContainsKey(Program.shell.memory.goal.vname))
            {
                SetTreeView(goal, tvRule);
            }
        }

        private void ListViewResizeColumns() //настроить ширину колонок listview
        {
            lvAnswer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvAnswer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void SetVariable()
        {
            var usedVar = Program.shell.memory.usedVar;
            foreach(var v in usedVar)
            {
                ListViewItem item = new ListViewItem(new string[] { v.variable.vname, v.value.value });
                lvAnswer.Items.Add(item);
            }
        }

        private TreeNode SetComponent(Rule usedRule)
        {
            var node = new TreeNode($"({usedRule.rname}) Цель: {usedRule.conclusion.GetInfo()}");
            node.Nodes.Add($"Пояснение: {usedRule.reason}");
            node.Nodes.Add("ЕСЛИ");
            foreach (var c in usedRule.condition)
            {
                var newNode = new TreeNode(c.GetInfo());
                newNode.Name = c.GetInfo();
                node.Nodes[1].Nodes.Add(newNode);
            }
            node.Nodes.Add("ТО");
            node.Nodes[2].Nodes.Add(usedRule.conclusion.GetInfo());
            return node;
        }

        private void SetTreeView(Variable goal, TreeView tree)
        {
            var usedRule = Program.shell.memory.usedRule[goal.vname];       

            tree.Nodes.Add(SetComponent(usedRule));

            foreach (var c in usedRule.condition)
            {
                if (Program.shell.memory.usedRule.ContainsKey(c.variable.vname))
                {
                    tree.Nodes[0].Nodes.Add(SetComponent(Program.shell.memory.usedRule[c.variable.vname]));
                    SetTreeViewChild(c.variable, tree.Nodes[0].Nodes[tree.Nodes[0].Nodes.Count - 1]);
                }
            }
        }

        private void SetTreeViewChild(Variable goal, TreeNode tree)
        {
            var usedRule = Program.shell.memory.usedRule[goal.vname];

            foreach (var c in usedRule.condition)
            {
                if (Program.shell.memory.usedRule.ContainsKey(c.variable.vname))
                {
                    tree.Nodes.Add(SetComponent(Program.shell.memory.usedRule[c.variable.vname]));
                    SetTreeViewChild(c.variable, tree.Nodes[tree.Nodes.Count - 1]);
                }
            }
        }

        private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //раскрыть/скрыть treeview
        {
            if (lblLink.Text == "(раскрыть все)")
            {
                tvRule.ExpandAll();
                lblLink.Text = "(скрыть все)";
            }
            else
            {
                tvRule.CollapseAll();
                lblLink.Text = "(раскрыть все)";
            }
        }

        private void ReasoningForm_Resize(object sender, EventArgs e) //настроить ширину колокнок listview при изменении размера экрана
        {
            ListViewResizeColumns();
        }

        private void lvAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fact != null)
            {
                tvRule.Nodes.Find(fact, true)[0].BackColor = Color.White;
            }

            if (lvAnswer.SelectedItems.Count > 0)
            {
                string name = lvAnswer.SelectedItems[0].Text;
                fact = $"{name} = {Program.shell.memory.usedVar.Find(item => item.variable.vname == name).value.value}";

                if (tvRule.Nodes.Find(fact, true).Length != 0)
                {
                    tvRule.Nodes.Find(fact, true)[0].BackColor = Color.PowderBlue;
                }
                else
                {
                    fact = null;
                }
            }
            else
            {
                fact = null;
            }
        }
    }
}
