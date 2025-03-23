using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;

namespace SquadsMaster.Models
{
    public class Players : IList<IPlayer>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public event NotifyCollectionChangedEventHandler? CollectionChanged;
        public event PropertyChangedEventHandler? PropertyChanged;

        List<IPlayer> _players;

        public Players(IEnumerable<IPlayer> players)
        {
            _players = [.. players];
        }

        #region "IList"

        public IPlayer this[int index]
        {
            get => _players[index];
            set
            {
                _players[index] = value;
                //notify collection changed
            }
        }

        public int Count { get; }
        public bool IsReadOnly { get; }

        public void Add(IPlayer item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(IPlayer item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(IPlayer[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<IPlayer> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(IPlayer item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, IPlayer item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(IPlayer item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
