using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class SurprisePriceActivityRequestModel {
		
		///<summary>
		/// 活动号
		///</summary>
		
		private string activityNo_;
		
		///<summary>
		/// 活动名
		///</summary>
		
		private string name_;
		
		///<summary>
		/// 开始时间
		///</summary>
		
		private System.DateTime? startTime_;
		
		///<summary>
		/// 结束时间
		///</summary>
		
		private System.DateTime? endTime_;
		
		///<summary>
		/// 长文案
		///</summary>
		
		private string longMessage_;
		
		///<summary>
		/// 长文案
		///</summary>
		
		private string shortMessage_;
		
		///<summary>
		/// 短文案
		///</summary>
		
		private string iconLink_;
		
		public string GetActivityNo(){
			return this.activityNo_;
		}
		
		public void SetActivityNo(string value){
			this.activityNo_ = value;
		}
		public string GetName(){
			return this.name_;
		}
		
		public void SetName(string value){
			this.name_ = value;
		}
		public System.DateTime? GetStartTime(){
			return this.startTime_;
		}
		
		public void SetStartTime(System.DateTime? value){
			this.startTime_ = value;
		}
		public System.DateTime? GetEndTime(){
			return this.endTime_;
		}
		
		public void SetEndTime(System.DateTime? value){
			this.endTime_ = value;
		}
		public string GetLongMessage(){
			return this.longMessage_;
		}
		
		public void SetLongMessage(string value){
			this.longMessage_ = value;
		}
		public string GetShortMessage(){
			return this.shortMessage_;
		}
		
		public void SetShortMessage(string value){
			this.shortMessage_ = value;
		}
		public string GetIconLink(){
			return this.iconLink_;
		}
		
		public void SetIconLink(string value){
			this.iconLink_ = value;
		}
		
	}
	
}