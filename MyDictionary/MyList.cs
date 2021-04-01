using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyList<TKey, TValue>
    {
        TKey[] _TKey;
        TValue[] _TValue;
        TKey[] _tempTKey;
        TValue[] _tempTValue;
        public MyList()
        {
            _TKey = new TKey[0];
            _TValue = new TValue[0];
        }
        public void Add(TKey itemKey, TValue itemValue)
        {
            _tempTKey = _TKey;
            _tempTValue = _TValue;
            _TKey = new TKey[_TKey.Length + 1];
            _TValue = new TValue[_TValue.Length + 1];
            for (int i = 0; i < _tempTKey.Length; i++)
            {
                _TKey[i] = _tempTKey[i];
                _TValue[i] = _tempTValue[i];
            }
            _TKey[_TKey.Length - 1] = itemKey;
            _TValue[_TValue.Length - 1] = itemValue;
        }

        public int Count
        {
            get { return _TKey.Length; }
        }

        public TKey[] Keys
        {
            get { return _TKey; }
        }

        public TValue[] Values
        {
            get { return _TValue; }
        }
    }
}
