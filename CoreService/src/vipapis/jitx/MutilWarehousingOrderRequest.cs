using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class MutilWarehousingOrderRequest {
		
		///<summary>
		/// 供应商id
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 查询开始时间（epoch格式时间戳），且小于endTime，最多可查询最近7天的数据
		/// @sampleValue start_time 1545876212
		///</summary>
		
		private long? start_time_;
		
		///<summary>
		/// 查询结束时间（epoch格式时间戳），且大于startTime，endTime-startTime最大不可超过30分钟
		/// @sampleValue end_time 1545876212
		///</summary>
		
		private long? end_time_;
		
		///<summary>
		/// 订单状态; NEW：新建；CONFIRMING：确认中；CONFIRMED：确认为JITX；ROLLBACK：确认为非JITX
		///</summary>
		
		private List<string> status_list_;
		
		///<summary>
		/// 当前请求页
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 页大小,最大1000条
		///</summary>
		
		private int? limit_;
		
		///<summary>
		/// 合作编码，最大20
		///</summary>
		
		private List<string> cooperation_nos_;
		
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public long? GetStart_time(){
			return this.start_time_;
		}
		
		public void SetStart_time(long? value){
			this.start_time_ = value;
		}
		public long? GetEnd_time(){
			return this.end_time_;
		}
		
		public void SetEnd_time(long? value){
			this.end_time_ = value;
		}
		public List<string> GetStatus_list(){
			return this.status_list_;
		}
		
		public void SetStatus_list(List<string> value){
			this.status_list_ = value;
		}
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(int? value){
			this.limit_ = value;
		}
		public List<string> GetCooperation_nos(){
			return this.cooperation_nos_;
		}
		
		public void SetCooperation_nos(List<string> value){
			this.cooperation_nos_ = value;
		}
		
	}
	
}