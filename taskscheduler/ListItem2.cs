using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskscheduler1 {
    class ListItem2 {
        private int id;
        private string text1;
        private string text2;

        public int getId() {
            return this.id;
        }

        public void setId(int id) {
            this.id = id;
        }

        public string getText1() {
            return this.text1;
        }

        public void setText1(string text) {
            this.text1 = text;
        }

        public string getText2() {
            return this.text2;
        }

        public void setText2(string text) {
            this.text2 = text;
        }
        public static string findText1InListitem2(List<ListItem2> list, String text2) {
            for (int i = 0; i < list.Count; i++) {
                if (list[i].getText2() == text2) {
                    return list[i].getText1();
                }
            }
            return "";
        }
    }
}
