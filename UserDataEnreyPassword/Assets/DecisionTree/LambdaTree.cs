using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq.Expressions;
using System.Linq;


 

class TreeNode
{
    public string Value { get; set; }
    public List<TreeNode> Nodes { get; set; }


    public TreeNode()
    {
        Nodes = new List<TreeNode>();
    }
}


public class LambdaTree : MonoBehaviour { 

// Use this for initialization
void Start () {
        Action<TreeNode> traverse = null;
        traverse = (n) => {
            if (n.Value.Contains("A"))
            {  
                Debug.Log(n.Value);  
            }
            n.Nodes.ForEach(traverse);
        }; 
        var root = new TreeNode { Value = "Root" };
        root.Nodes.Add(new TreeNode { Value = "AROM" });
        root.Nodes[0].Nodes.Add(new TreeNode { Value = "ChildAROM1" });
        root.Nodes[0].Nodes.Add(new TreeNode { Value = "ChildAROM2" });
        root.Nodes[0].Nodes.Add(new TreeNode { Value = "ChildAROM3" });
        root.Nodes.Add(new TreeNode { Value = "ChildB" });
        root.Nodes[1].Nodes.Add(new TreeNode { Value = "ChildB1" });
        root.Nodes[1].Nodes.Add(new TreeNode { Value = "ChildB2" });
         traverse(root);
         
        /*
        // Factorial recursive
        Func<int, int> fact = null;
        fact = x => (x == 0) ? 1 : x * fact(x - 1);
        Func<int, int> myFact = fact;
        Debug.Log( myFact(4));*/
        /*
        List<String> names = new List<String>();
        names.Add("Bruce");
        names.Add("Alfred");
        names.Add("Tim");
        names.Add("Richard");
        //https://msdn.microsoft.com/en-us/library/bwabdf9z.aspx
        names.ForEach(delegate (String name){
           Debug.Log(name);
        });
        */
        List<Int32> nums = new List<int>();

        nums.Add(3);
        nums.Add(10);
        nums.Add(5);

        var results = nums.Where(x => x == 3 || x == 10);
         
        foreach (int item in results)
        {
            Debug.Log(item);
        }
        

    }

    
}
