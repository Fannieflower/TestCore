using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractDetailQueryParam {
		
		///<summary>
		/// 确认函编号
		///</summary>
		
		private string protNo_;
		
		///<summary>
		/// 流程审批完成时间start
		///</summary>
		
		private string processCompletedTimeStart_;
		
		///<summary>
		/// 流程审批完成时间end
		///</summary>
		
		private string processCompletedTimeEnd_;
		
		public string GetProtNo(){
			return this.protNo_;
		}
		
		public void SetProtNo(string value){
			this.protNo_ = value;
		}
		public string GetProcessCompletedTimeStart(){
			return this.processCompletedTimeStart_;
		}
		
		public void SetProcessCompletedTimeStart(string value){
			this.processCompletedTimeStart_ = value;
		}
		public string GetProcessCompletedTimeEnd(){
			return this.processCompletedTimeEnd_;
		}
		
		public void SetProcessCompletedTimeEnd(string value){
			this.processCompletedTimeEnd_ = value;
		}
		
	}
	
}