﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3Commas.BotCreator.Infrastructure
{
    public class MessageBoxService : IMessageBoxService
    {
        public DialogResult ShowError(string text, string title = "Error")
        {
            return MessageBox.Show(text, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public DialogResult ShowQuestion(string text)
        {
            return MessageBox.Show(text, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public DialogResult ShowInformation(string text)
        {
            return MessageBox.Show(text, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}