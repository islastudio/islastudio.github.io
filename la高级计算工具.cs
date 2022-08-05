//以下是非公布个人版

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class Program 
    {
        public static void Main()
        {
			void shiyongtishi(){//用户提示函数
        	    Console.WriteLine("欢迎使用由la工作室出品的高级计算器(点击任意键继续)");
        	    Console.ReadKey();
        	    
        	}//用户提示
        	shiyongtishi();//用户提示调用
        	
        	
        	
        	for (int jisuancishu = 0;jisuancishu<100;jisuancishu++)
        	
        	{
        		Console.WriteLine("请选择模式");
        		Console.WriteLine("0.结束所有进程");
        		Console.WriteLine("1.加法");
        		Console.WriteLine("2.减法");
        		Console.WriteLine("3.乘法");
        		Console.WriteLine("4.除法");
        		Console.WriteLine("5.乘方(仅2次)");
        		Console.WriteLine("6.开方(仅2次)");
        		Console.WriteLine("7.字符多次输出(重复骂人用)");
        		Console.WriteLine("8.热值");
        		
        	
        	    string yonghuxiuanze = Console.ReadLine();
        	    int yonghuxiuanze2 = Convert.ToInt32(yonghuxiuanze);
        	    
                jisuancishu = jisuancishu + 1;
                if (yonghuxiuanze2 == (int)0)
                {
                	Console.WriteLine("进程已结束，非常感谢使用");
                	break;
                }//结束进程
        	    if (yonghuxiuanze2 == (int)1)
        	    {
        		    jia();
        		    continue;
        	    }//加法调用
        	    if (yonghuxiuanze2 == (int)2)
        	    {
        		    jian();
        		    continue;
        	    }//减法调用
        	    if (yonghuxiuanze2 == (int)3)
        	    {
        	    	ChenFa();
        	    	continue;
        	    }//乘法调用
        	    if (yonghuxiuanze2 == (int)4)
        	    {
        	    	ChuFa();
        	    	continue;
        	    }//除法调用
        	    if (yonghuxiuanze2 == (int)5)
        	    {
        	    	ChengFang();
        	    	continue;
        	    }//乘方
        	    if (yonghuxiuanze2 == (int)6)
        	    {
        	    	KaiFang();
        	    	continue;
        	    }//开方
        	    if (yonghuxiuanze2 == (int)7)
        	    {
        	    	ZiFuChuanChongFuShuSu();
        	    	continue;
        	    }//重复输出
        	    if (yonghuxiuanze2 == (int)8)
        	    {
        	    	ReZhi();
        	    	continue;
        	    }//热值
        	
        	}
        	
        	void djryjjx (){
        		Console.WriteLine("点击回车继续");
        	}//回车继续
        	
        	void jia(){
        		Console.Clear();
        		Console.WriteLine("请输入加数");
        		string jiashu = Console.ReadLine();
        		int jiashu2 = Convert.ToInt32(jiashu);
        		Console.WriteLine("请输入被加数");
        		string beijiashu = Console.ReadLine();
        		int beijiashu2 = Convert.ToInt32(beijiashu);
        		Console.WriteLine("结果是{0}",jiashu2+beijiashu2,"点击任意键回到总级");
        		djryjjx();
        		Console.ReadKey();
        		Console.Clear();
        		
        	
        		
        	}//加法
        	void jian(){
        		Console.Clear();
        		Console.WriteLine("请输入被减数");
        		string jiashu = Console.ReadLine();
        		int jiashu2 = Convert.ToInt32(jiashu);
        		Console.WriteLine("请输入减数");
        		string beijiashu = Console.ReadLine();
        		int beijiashu2 = Convert.ToInt32(beijiashu);
        		Console.WriteLine("结果是{0}",jiashu2-beijiashu2);
        		djryjjx();
        		Console.ReadKey();
        		Console.Clear();
        	}//减法
        	void ChenFa(){
        		Console.Clear();
        		Console.WriteLine("请输入乘数");
        		string jiashu = Console.ReadLine();
        		int jiashu2 = Convert.ToInt32(jiashu);
        		Console.WriteLine("请输入被乘数");
        		string beijiashu = Console.ReadLine();
        		int beijiashu2 = Convert.ToInt32(beijiashu);
        		Console.WriteLine("结果是{0}",jiashu2*beijiashu2);
        		djryjjx();
        		Console.ReadKey();
        		Console.Clear();
        	}//乘法
        	void ChuFa(){
        		Console.Clear();
        		Console.WriteLine("请输入除数");
        		string jiashu = Console.ReadLine();
        		int jiashu2 = Convert.ToInt32(jiashu);
        		Console.WriteLine("请输入被除数");
        		string beijiashu = Console.ReadLine();
        		int beijiashu2 = Convert.ToInt32(beijiashu);
        		Console.WriteLine("结果是{0}",(double)jiashu2/(double)beijiashu2);
        		djryjjx();
        		Console.ReadKey();
        		Console.Clear();
        	}//除法
        	void ChengFang(){
        		Console.Clear();
        		Console.WriteLine("请输入要乘方的数(可能是负数，因为不是算术平方)");
        		string yaochengfangdeshu = Console.ReadLine();
        	    int yaochengfangdeshu2 = Convert.ToInt32(yaochengfangdeshu);
        	    Console.WriteLine("结果是{0}",yaochengfangdeshu2*yaochengfangdeshu2);
        	    djryjjx();
        	    Console.ReadKey();
        	    Console.Clear();
        	
        		
        	}//乘方
        	void KaiFang(){
        		Console.Clear();
        		Console.WriteLine("请输入要开方的数");
        		string BeiKaiFangShu = Console.ReadLine();
        		double BeiKaiFangShu2 = double.Parse(BeiKaiFangShu);
        		double BeiKaiFangShu3 = Math.Pow(BeiKaiFangShu2,0.5);
        		Console.WriteLine("结果是{0}",BeiKaiFangShu3);
        		djryjjx();
        		Console.ReadKey();
        		Console.Clear();
        	}//开方
        	void ZiFuChuanChongFuShuSu(){
        		Console.Clear();
        		Console.WriteLine("请输入要重复输出的字符");
        		string YaoChongFuShuShuDeZiFuChuan = Console.ReadLine();
        		Console.WriteLine("请输入要重复输出的次数");
        		string ShuChuCiShu = Console.ReadLine();
        		int ShuChuCiShu2 = Convert.ToInt32(ShuChuCiShu);
        		for (int i=0 ;i<ShuChuCiShu2;i++)
        		{
        			Console.Write(YaoChongFuShuShuDeZiFuChuan);
        			
        		}
        		Console.WriteLine("回车继续");
        		Console.ReadKey();
        		Console.Clear();
        		
        		
        	}//重复字符串输出
        	void ReZhi(){
        		Console.Clear();
        		Console.WriteLine("q:热值 Q:燃料放出的热量 m：燃料的质量");
        		Console.WriteLine("使用公式 q=Q/m");
        		Console.WriteLine("1:知Q,m；求q");
        		Console.WriteLine("2:知q,m；求Q");
        		Console.WriteLine("3:知Q,q；求m");
        		Console.WriteLine("请输入：");
        		string yonghuxiuanze = Console.ReadLine();
        	    int yonghuxiuanze2 = Convert.ToInt32(yonghuxiuanze);
        	    if (yonghuxiuanze2 == (int)1)
        	    {
        		    Console.Clear();
        		    Console.WriteLine("请输入Q");
        		    string jiashu = Console.ReadLine();
        		    int jiashu2 = Convert.ToInt32(jiashu);
        		    Console.WriteLine("请输入m");
        	    	string beijiashu = Console.ReadLine();
        		    int beijiashu2 = Convert.ToInt32(beijiashu);
        		    Console.WriteLine("q是{0}",(double)jiashu2/(double)beijiashu2);
        	    	djryjjx();
        	    	Console.ReadKey();
        	    	Console.Clear();
        		    
        	    }
        	    if (yonghuxiuanze2 == (int)2)
        	    {
        		   
        		    Console.Clear();
        		    Console.WriteLine("请输入m");
        		    string jiashu = Console.ReadLine();
        	    	int jiashu2 = Convert.ToInt32(jiashu);
        		    Console.WriteLine("请输入q");
        	    	string beijiashu = Console.ReadLine();
            		int beijiashu2 = Convert.ToInt32(beijiashu);
            		Console.WriteLine("结果是{0}",jiashu2*beijiashu2);
            		djryjjx();
             		Console.ReadKey();
            		Console.Clear();
        	    }
        	    if (yonghuxiuanze2 == (int)3)
        	    {
        	    	Console.Clear();
        	    	Console.WriteLine("请输入Q");
            		string jiashu = Console.ReadLine();
            		int jiashu2 = Convert.ToInt32(jiashu);
            		Console.WriteLine("请输入q");
             		string beijiashu = Console.ReadLine();
            		int beijiashu2 = Convert.ToInt32(beijiashu);
            		Console.WriteLine("结果是{0}",(double)jiashu2/(double)beijiashu2);
        		    djryjjx();
            		Console.ReadKey();
            		Console.Clear();
         	    }
        		
        		
        		
        		
        		
        		
        	}//热值
         
        	
        	
        	
      
        	 
        }
    }
}