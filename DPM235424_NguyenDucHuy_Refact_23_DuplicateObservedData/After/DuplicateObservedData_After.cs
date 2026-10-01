using System;

namespace DPM235424_NguyenDucHuy_Refact_23_DuplicateObservedData.After
{
    // Domain Model độc lập, không dính líu đến UI
    public class Interval
    {
        private int _start;
        private int _end;
        private int _length;

        public event Action OnDataChanged;

        public int Start
        {
            get { return _start; }
            set
            {
                _start = value;
                CalculateLength();
            }
        }

        public int End
        {
            get { return _end; }
            set
            {
                _end = value;
                CalculateLength();
            }
        }

        public int Length
        {
            get { return _length; }
        }

        private void CalculateLength()
        {
            _length = _end - _start;
            if (OnDataChanged != null)
            {
                OnDataChanged.Invoke();
            }
        }
    }

    // View/Window quan sát dữ liệu từ Domain Model
    public class DuplicateObservedData_After
    {
        private Interval _subject;
        public string TxtStart { get; set; }
        public string TxtEnd { get; set; }
        public string TxtLength { get; set; }

        public DuplicateObservedData_After()
        {
            _subject = new Interval();
            // Đăng ký nhận thông báo thay đổi từ Model (Observer Pattern)
            _subject.OnDataChanged += SyncFromModel;

            _subject.Start = 100;
            _subject.End = 150;
        }

        private void SyncFromModel()
        {
            TxtStart = _subject.Start.ToString();
            TxtEnd = _subject.End.ToString();
            TxtLength = _subject.Length.ToString();
            Console.WriteLine(string.Format("[UI After - Đồng bộ tự động] Length hiển thị: {0}", TxtLength));
        }

        public void UserChangesEnd(string newEnd)
        {
            _subject.End = int.Parse(newEnd);
        }
    }
}