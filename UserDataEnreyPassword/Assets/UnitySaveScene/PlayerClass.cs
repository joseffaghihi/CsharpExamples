using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

namespace PlayerGame
{
    public class PlayerClass: IEnumerable<PlayerLevel> 
    {
        private int _playerIdNumber;
        private string _name;
        private List<PlayerLevel> _playerLevels;
         

      
        public int PlayerIdNumber
        {
            get { return _playerIdNumber; }
            set { _playerIdNumber = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        } 

        public List<PlayerLevel> PlayerLevels
        {
            get { return _playerLevels; }
            set { _playerLevels = value; }
        }
        
      
        IEnumerator<PlayerLevel> IEnumerable<PlayerLevel>.GetEnumerator()
        {
            return this._playerLevels.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this._playerLevels.GetEnumerator();
        } 
    }
    public class PlayerLevel 
    {
        private int _levelId;
        public int LevelId
        {
            get { return _levelId; }
            set { _levelId = value; }

        }
    }

    


}

