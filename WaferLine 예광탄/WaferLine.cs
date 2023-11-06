using System;
using System.Collections;
using System.Collections.Generic;
using WaferLineLib;

namespace WaferLine_예광탄
{
    /// <summary>
    /// WaferLine 클래스
    /// </summary>
    public class WaferLine:IEnumerable<Wafer>
    {
        readonly int no;
        public WaferLine(int no) 
        {
            Spin = 2000;
            Drop = 20;
            this.no = no;
        }

        /// <summary>
        /// WaferLine 일련 번호 - 가져오기
        /// </summary>
        public int No { get { return no; } }
        /// <summary>
        /// 코팅 회전 속도 - 가져오기 
        /// </summary>
        public int Spin { get; private set; }
        /// <summary>
        /// 코팅액 낙하 속도 - 가져오기
        /// </summary>
        public int Drop { get; private set; }
        List<Wafer> bwafers = new List<Wafer>();//코팅 전 Wafer 컬렉션
        List<Wafer> awafers = new List<Wafer>();//코팅 후 Wafer 컬렉션
        /// <summary>
        /// 가장 최근에 코팅한 Wafer - 가져오기
        /// </summary>
        public Wafer LastWafer
        {
            get
            {
                if(awafers.Count==0)
                {
                    return null;
                }
                return awafers[awafers.Count-1];
            }
        }
        /// <summary>
        /// 중앙 관제에서 실제 생산 라인과 Wafer 개수를 동기화하는 메서드
        /// </summary>
        /// <param name="bwcnt">코팅 전 Wafer 개수</param>
        /// <param name="awcnt">코팅 후 Wafer 개수</param>
        public void EndCoating(int bwcnt,int awcnt)
        {
            while(bwafers.Count>bwcnt)
            {
                bwafers.RemoveAt(0);
            }
            while(awafers.Count<awcnt)
            {
                awafers.Add(null);
            }
        }

        Wafer nwafer;//현재 코팅 중인 Wafer
        int nowp;//현재 코팅에 사용하는 코팅액

        /// <summary>
        /// 현재 코팅 중인 Wafer - 가져오기
        /// </summary>
        public Wafer Now
        {
            get
            {
                return nwafer;
            }
        }
        /// <summary>
        /// 코팅 전 Wafer 개수 - 가져오기
        /// </summary>
        public int BWCnt
        {
            get
            {
                return bwafers.Count;
            }
        }
        /// <summary>
        /// 코팅 완료한 Wafer 개수 - 가져오기
        /// </summary>
        public int AWCnt
        {
            get
            {
                return awafers.Count;
            }
        }
        /// <summary>
        /// 코팅에 사용하는 코팅액 남은 량 - 가져오기
        /// </summary>
        public int NPcnt
        {
            get
            {
                return nowp;
            }
        }
        /// <summary>
        /// 코팅 액 병 수 - 가져오기 및 설정하기
        /// </summary>
        public int PCnt
        {
            get;
            set;            
        }
        /// <summary>
        /// 코팅액 투입 메서드
        /// </summary>
        /// <param name="pcnt">투입할 병 수</param>
        /// <returns>보관 중인 코팅액 병 수</returns>
        public int InPr(int pcnt)
        {
            int avail = 20 - PCnt;
            if(pcnt>avail)
            {
                pcnt = avail;
            }
            PCnt += pcnt;
            return PCnt;
        }
        /// <summary>
        /// 회전 속도 설정
        /// </summary>
        /// <param name="spin">회전 속도</param>
        public void SetSpin(int spin)
        {
            Spin = spin;
        }
        /// <summary>
        /// 낙하 속도 설정
        /// </summary>
        /// <param name="drop">낙하 속도</param>
        public void SetDrop(int drop)
        {
            Drop = drop;
        }
        Random random = new Random();
        public bool Coating()
        {
            if(nowp==0)
            {
                if(PCnt==0)
                {
                    return false;
                }
                PCnt--;
                nowp = 1000;
            }
            if(nwafer == null)
            {
                if(bwafers.Count==0)
                {
                    return false;
                }
                nwafer = bwafers[0];
                bwafers.RemoveAt(0);
            }
            nwafer.Coating(random.Next(70,100));//하나의 쉘 코팅
            nowp--;//코팅액 1 소진
            if(nwafer.Increment()==false)//다음 쉘로 이동 실패 - 코팅 완료
            {
                awafers.Add(nwafer);//코팅 후 컬렉션에 보관
                nwafer = null;//현태 코팅하는 Wafer는 없음
            }
            return true;//코팅 성공
        }
        /// <summary>
        /// ToString 메서드 재정의
        /// </summary>
        /// <returns>생산 라인 번호</returns>
        public override string ToString()
        {
            return string.Format("WaferLine No:{0}", No);
        }

        /// <summary>
        /// Get 열거자 
        /// </summary>
        /// <returns>코팅 후 Wafer 컬렉션 열거자</returns>
        public IEnumerator<Wafer> GetEnumerator()
        {
            return awafers.GetEnumerator();
        }
        /// <summary>
        /// Get 열거정
        /// </summary>
        /// <returns>코팅 후 Wafer 컬렉션 열거자</returns>

        IEnumerator IEnumerable.GetEnumerator()
        {
            return awafers.GetEnumerator();
        }
        /// <summary>
        /// Wafer 투입 매서드
        /// </summary>
        /// <param name="wcnt">투입할 wafer 개수</param>
        /// <returns>코팅 전 wafer 개수</returns>
        public int InWafer( int wcnt)
        {
            int avail = 200 - BWCnt;
            if(wcnt > avail)
            {
                wcnt = avail;
            }
            for(int i = 0; i<wcnt; i++)
            {
                bwafers.Add(new Wafer());
            }
            return bwafers.Count;
        }
    }
}
