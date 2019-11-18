using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.asc{
	
	
	
	
	
	public class ProblemOrder {
		
		///<summary>
		/// 工单号
		///</summary>
		
		private string wd_no_;
		
		///<summary>
		/// 工单类型
		///</summary>
		
		private string category_3_name_;
		
		///<summary>
		/// 工单状态
		///</summary>
		
		private string vis_status_str_;
		
		///<summary>
		/// 当前是否超时
		///</summary>
		
		private string is_delay_str_;
		
		///<summary>
		/// 工单结案时间
		///</summary>
		
		private string end_time_;
		
		public string GetWd_no(){
			return this.wd_no_;
		}
		
		public void SetWd_no(string value){
			this.wd_no_ = value;
		}
		public string GetCategory_3_name(){
			return this.category_3_name_;
		}
		
		public void SetCategory_3_name(string value){
			this.category_3_name_ = value;
		}
		public string GetVis_status_str(){
			return this.vis_status_str_;
		}
		
		public void SetVis_status_str(string value){
			this.vis_status_str_ = value;
		}
		public string GetIs_delay_str(){
			return this.is_delay_str_;
		}
		
		public void SetIs_delay_str(string value){
			this.is_delay_str_ = value;
		}
		public string GetEnd_time(){
			return this.end_time_;
		}
		
		public void SetEnd_time(string value){
			this.end_time_ = value;
		}
		
	}
	
}