using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.wo{
	
	
	
	
	
	public class RecheckResult {
		
		///<summary>
		/// 工单号
		/// @sampleValue work_order_no DH201812274412200
		///</summary>
		
		private string work_order_no_;
		
		///<summary>
		/// 复核状态：0-处理中,1-结案,2-放弃,3-下送
		/// @sampleValue recheck_state 0
		///</summary>
		
		private int? recheck_state_;
		
		///<summary>
		/// 复核最新记录 1=新记录 
		/// @sampleValue is_new 
		///</summary>
		
		private int? is_new_;
		
		///<summary>
		/// 复核时间 （单位:毫秒）
		/// @sampleValue recheck_time 1566437975000
		///</summary>
		
		private long? recheck_time_;
		
		///<summary>
		/// 复核到期时间 （单位:毫秒）
		/// @sampleValue expire_time 1566437975000
		///</summary>
		
		private long? expire_time_;
		
		///<summary>
		/// 复核问题
		/// @sampleValue recheck_problem 已短信告知快递单号
		///</summary>
		
		private string recheck_problem_;
		
		///<summary>
		/// 复核处理内容
		/// @sampleValue recheck_process_content 客服已处理
		///</summary>
		
		private string recheck_process_content_;
		
		///<summary>
		/// 创建时间 （单位:毫秒）
		/// @sampleValue create_time 1566437975000
		///</summary>
		
		private long? create_time_;
		
		public string GetWork_order_no(){
			return this.work_order_no_;
		}
		
		public void SetWork_order_no(string value){
			this.work_order_no_ = value;
		}
		public int? GetRecheck_state(){
			return this.recheck_state_;
		}
		
		public void SetRecheck_state(int? value){
			this.recheck_state_ = value;
		}
		public int? GetIs_new(){
			return this.is_new_;
		}
		
		public void SetIs_new(int? value){
			this.is_new_ = value;
		}
		public long? GetRecheck_time(){
			return this.recheck_time_;
		}
		
		public void SetRecheck_time(long? value){
			this.recheck_time_ = value;
		}
		public long? GetExpire_time(){
			return this.expire_time_;
		}
		
		public void SetExpire_time(long? value){
			this.expire_time_ = value;
		}
		public string GetRecheck_problem(){
			return this.recheck_problem_;
		}
		
		public void SetRecheck_problem(string value){
			this.recheck_problem_ = value;
		}
		public string GetRecheck_process_content(){
			return this.recheck_process_content_;
		}
		
		public void SetRecheck_process_content(string value){
			this.recheck_process_content_ = value;
		}
		public long? GetCreate_time(){
			return this.create_time_;
		}
		
		public void SetCreate_time(long? value){
			this.create_time_ = value;
		}
		
	}
	
}