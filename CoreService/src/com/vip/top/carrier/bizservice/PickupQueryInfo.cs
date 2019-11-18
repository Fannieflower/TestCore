using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class PickupQueryInfo {
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string custCode_;
		
		///<summary>
		/// 站点名称
		///</summary>
		
		private string pointName_;
		
		///<summary>
		/// 交接开始时间
		///</summary>
		
		private string beginTime_;
		
		///<summary>
		/// 交接结束时间
		///</summary>
		
		private string endTime_;
		
		///<summary>
		/// 交接人
		///</summary>
		
		private string opName_;
		
		public string GetCustCode(){
			return this.custCode_;
		}
		
		public void SetCustCode(string value){
			this.custCode_ = value;
		}
		public string GetPointName(){
			return this.pointName_;
		}
		
		public void SetPointName(string value){
			this.pointName_ = value;
		}
		public string GetBeginTime(){
			return this.beginTime_;
		}
		
		public void SetBeginTime(string value){
			this.beginTime_ = value;
		}
		public string GetEndTime(){
			return this.endTime_;
		}
		
		public void SetEndTime(string value){
			this.endTime_ = value;
		}
		public string GetOpName(){
			return this.opName_;
		}
		
		public void SetOpName(string value){
			this.opName_ = value;
		}
		
	}
	
}