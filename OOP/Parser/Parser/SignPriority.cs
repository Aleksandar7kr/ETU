using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parser
{
    class SignPriority
    {
        public SignPriority(int pos, String sign, bool priority) // конструктор класса
        {
		    this.pos = pos;
		    this.sign = sign;
		    this.priority = priority;
	    }

        public SignPriority() // конструктор класса
        {
		    pos = 0;
		    sign = "";
		    priority = false;
	    }

        public int getPos() // доступ к позиции
        {
		    return pos;
	    }

        public void setPos(int pos) // установка позиции
        {
		    this.pos = pos;
	    }

        public String getSign() // доступ к знаку
        {
		    return sign;
	    }

        public void setSign(String sign) // установка знака
        {
		    this.sign = sign;
	    }

        public bool isPriority() // доступ к флажку приоритетности
        {
		    return priority;
	    }

        public void setPriority(bool priority) // установка приоритетности
        {
		    this.priority = priority;
	    }

	    private int pos; // позиция знака
        private string sign; // знак
        private bool priority; // приоритет
    }
}
