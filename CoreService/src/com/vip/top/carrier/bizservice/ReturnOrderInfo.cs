using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class ReturnOrderInfo {
		
		///<summary>
		/// 揽退运单号 
		///</summary>
		
		private string transportNo_;
		
		///<summary>
		/// 承运商名称 
		///</summary>
		
		private string custName_;
		
		///<summary>
		/// 揽退状态
		///</summary>
		
		private string returnStatus_;
		
		///<summary>
		/// 预约时间,yyyy-MM-dd
		///</summary>
		
		private string appointmentReturnTime_;
		
		///<summary>
		/// 超时时间,yyyy-MM-dd HH:mm:ss
		///</summary>
		
		private string overReturnTime_;
		
		///<summary>
		/// 实际时间,yyyy-MM-dd HH:mm:ss
		///</summary>
		
		private string actualReturnTime_;
		
		public string GetTransportNo(){
			return this.transportNo_;
		}
		
		public void SetTransportNo(string value){
			this.transportNo_ = value;
		}
		public string GetCustName(){
			return this.custName_;
		}
		
		public void SetCustName(string value){
			this.custName_ = value;
		}
		public string GetReturnStatus(){
			return this.returnStatus_;
		}
		
		public void SetReturnStatus(string value){
			this.returnStatus_ = value;
		}
		public string GetAppointmentReturnTime(){
			return this.appointmentReturnTime_;
		}
		
		public void SetAppointmentReturnTime(string value){
			this.appointmentReturnTime_ = value;
		}
		public string GetOverReturnTime(){
			return this.overReturnTime_;
		}
		
		public void SetOverReturnTime(string value){
			this.overReturnTime_ = value;
		}
		public string GetActualReturnTime(){
			return this.actualReturnTime_;
		}
		
		public void SetActualReturnTime(string value){
			this.actualReturnTime_ = value;
		}
		
	}
	
}