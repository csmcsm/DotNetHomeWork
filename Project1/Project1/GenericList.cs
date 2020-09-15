using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
 
    public class GenericList<T> {
        private Node<T> head;
        private Node<T> tail;
        public GenericList() { 
            tail=head=null;
    }
        public Node<T> Head{
            get { return head; }
        }

        public void Add(T t){
        Node<T> n =new Node<T>(t);
            if(tail==null){
                head=tail=n;
            }else{
                tail.Next=n;
                tail=n;
            }
        
        }

    }
}
