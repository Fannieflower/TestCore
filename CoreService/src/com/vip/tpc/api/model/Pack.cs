using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class Pack {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string transportNo_;
		
		///<summary>
		/// 重量，单位为千克（KG），精确到4位小数，重量体积二者必须有一
		///</summary>
		
		private string weight_;
		
		///<summary>
		/// 体积，单位为立方米（m³）,精确到4位小数，重量体积二者必须有一
		///</summary>
		
		private string volume_;
		
		///<summary>
		/// 下单结果，1，成功；0，失败。
		///</summary>
		
		private string status_;
		
		///<summary>
		/// 结果信息，结果信息说明文字，如出错原因等.
		///</summary>
		
		private string result_;
		
		public string GetTransportNo(){
			return this.transportNo_;
		}
		
		public void SetTransportNo(string value){
			this.transportNo_ = value;
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
		public string GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(string value){
			this.status_ = value;
		}
		public string GetResult(){
			return this.result_;
		}
		
		public void SetResult(string value){
			this.result_ = value;
		}
		
	}
	
}