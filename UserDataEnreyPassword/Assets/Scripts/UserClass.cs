using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;

public class UserClass : MonoBehaviour {

    static public user player = new user(null, null, null, null, null, null, null, false, -1, null);
    [System.Serializable]
    public class user
    { 
        public string userId;
        public string firstName;
        public string lastName;
        public string email;
        public string dob;
        public string pn;
        public string problemId;
        public bool success;
        public int score;
        public string hintId;

        public user(string userId1, string fn, string ln, string email1, string dob1, string pn1,
            string problemId1, bool success1, int score1, string hintId1)
        {
            userId = userId1;
            firstName = fn;
            lastName = ln;
            email = email1;
            dob = dob1;
            pn = pn1;
            problemId = problemId1;
            success = success1;
            score = score1;
            hintId = hintId1;
        }

        public void setUserId(string userId1)
        {
            userId = userId1;
        }
        public string getUserId()
        {
            return userId;
        }

        public void setProblemId(string problemId1)
        {
            problemId = problemId1;
        }
        public string getProblemId()
        {
            return problemId;
        }

        public void setSuccess(bool success1)
        {
            success = success1;
        }
        public bool getSuccess()
        {
            return success;
        }

        public void setScore(int score1)
        {
            score = score1;
        }
        public int getScore()
        {
            return score;
        }

        public void setHintId(string hintId1)
        {
            hintId = hintId1;
        }
        public string getHintId()
        {
            return hintId;
        }

        public void printUser()
        {
            
        }
    }
 
    static public List<user> record = new List<user>();

    public void printList()
    {
        foreach (user i in record)
            i.printUser();
    }

}
