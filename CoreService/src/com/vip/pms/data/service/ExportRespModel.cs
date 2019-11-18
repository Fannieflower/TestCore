using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class ExportRespModel {
		
		///<summary>
		/// 券号
		///</summary>
		
		private string sn_;
		
		///<summary>
		/// 券的开始时间
		///</summary>
		
		private System.DateTime? beginTime_;
		
		///<summary>
		/// 券的结束时间
		///</summary>
		
		private System.DateTime? endTime_;
		
		public string GetSn(){
			return this.sn_;
		}
		
		public void SetSn(string value){
			this.sn_ = value;
		}
		public System.DateTime? GetBeginTime(){
			return this.beginTime_;
		}
		
		public void SetBeginTime(System.DateTime? value){
			this.beginTime_ = value;
		}
		public System.DateTime? GetEndTime(){
			return this.endTime_;
		}
		
		public void SetEndTime(System.DateTime? value){
			this.endTime_ = value;
		}
		
	}
	
}