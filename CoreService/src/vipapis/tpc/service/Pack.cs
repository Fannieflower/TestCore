using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.tpc.service{
	
	
	
	
	
	public class Pack {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transportNo_;
		
		///<summary>
		/// 原运单号
		///</summary>
		
		private string originalTransportNo_;
		
		///<summary>
		/// 重量，单位为千克（KG）保留4位小数
		///</summary>
		
		private string weight_;
		
		///<summary>
		/// 体积，单位为立方米（m³）保留4位小数
		///</summary>
		
		private string volume_;
		
		///<summary>
		/// 揽收时间,Unix时间戳 精度：秒
		///</summary>
		
		private long? time_;
		
		///<summary>
		/// 揽收人员
		///</summary>
		
		private string taker_;
		
		public string GetTransportNo(){
			return this.transportNo_;
		}
		
		public void SetTransportNo(string value){
			this.transportNo_ = value;
		}
		public string GetOriginalTransportNo(){
			return this.originalTransportNo_;
		}
		
		public void SetOriginalTransportNo(string value){
			this.originalTransportNo_ = value;
		}
		public string GetWeight(){
			return this.weight_;
		}
		
		public void SetWeight(string value){
			this.weight_ = value;
		}
		public string GetVolume(){
			return this.volume_;
		}
		
		public void SetVolume(string value){
			this.volume_ = value;
		}
		public long? GetTime(){
			return this.time_;
		}
		
		public void SetTime(long? value){
			this.time_ = value;
		}
		public string GetTaker(){
			return this.taker_;
		}
		
		public void SetTaker(string value){
			this.taker_ = value;
		}
		
	}
	
}