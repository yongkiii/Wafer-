namespace WaferLineLib
{
    /// <summary>
    /// Wafer 클래스
    /// </summary>
    public class Wafer
    {
        static int last_wn;//가장 최근에 부여한 웨이퍼 일련 번호
        readonly int wn;//웨이퍼 일련 번호
        int[] cells = new int[100];
        /// <summary>
        /// 쉘의 품질 수준(인덱서) - 가져오기
        /// </summary>
        /// <param name="index">쉘 인덱스(0~99)</param>
        /// <returns>품질 수준</returns>
        public int this[int index]
        {
            get
            {
                if ((index < 0) || (index >= 100))
                {
                    return 0;
                }
                return cells[index];
            }
        }
        /// <summary>
        /// 품질 수준 - 가져오기
        /// </summary>
        public double Quality
        {
            get
            {
                int sum = 0;
                foreach (int elem in cells)
                {
                    sum += elem;
                }
                return sum / 100.0;
            }
        }
        int now;
        /// <summary>
        /// 현재 코딩하는 쉘 번호 - 가져오기
        /// </summary>
        public int Now
        {
            get
            {
                return now;
            }
        }
        /// <summary>
        /// 기본 생성자
        /// </summary>
        public Wafer()
        {
            //웨이퍼 일련 번호 순차 부여
            last_wn++;
            wn = last_wn;
        }
        /// <summary>
        /// 코팅할 쉘 번호 1 증가 메서드
        /// </summary>
        /// <returns>다음 쉘이 있으면 true, 없으면 false</returns>
        public bool Increment()
        {
            if (now < 100)
            {
                now++;
                if (now == 100)//마지막 쉘을 코팅 완료-Wafer 코팅 완료
                {
                    return false;
                }
                return true;
            }
            return false;//이미 코팅 완료한 Wafer임
        }
        /// <summary>
        /// 코팅 메서드
        /// </summary>
        /// <param name="quality">품질 수준</param>
        public void Coating(int quality)
        {
            if (Now < 100)
            {
                cells[Now] = quality;
            }
        }
        /// <summary>
        /// ToString 재정의
        /// </summary>
        /// <returns>웨이퍼 번호, 품질 수준</returns>
        public override string ToString()
        {
            return string.Format("No:{0} Quality:{1}", wn, Quality);
        }


    }
}
