using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskscheduler1 {
    class ListItem {
        private int id;
        private string text;

        public int getId() {
            return this.id;
        }

        public void setId(int id) {
            this.id = id;
        }

        public string getText() {
            return this.text;
        }

        public void setText(string text) {
            this.text = text;
        }
    }
}
