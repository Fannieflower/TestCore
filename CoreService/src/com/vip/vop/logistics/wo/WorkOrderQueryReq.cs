using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.wo{
	
	
	
	
	
	public class WorkOrderQueryReq {
		
		///<summary>
		/// 承运商编码
		/// @sampleValue carrier_code shunfeng
		///</summary>
		
		private string carrier_code_;
		
		///<summary>
		/// 工单分发开始时间 （单位：毫秒）时间和工单号必选其一
		/// @sampleValue distribute_start_time 1566437975000
		///</summary>
		
		private long? distribute_start_time_;
		
		///<summary>
		/// 工单分发结束时间, 开始、结束时间间隔不能大于10分钟，否则以开始时间为准，加10分钟为结束时间（单位：毫秒）,时间和工单号必选其一
		/// @sampleValue distribute_end_time 1566437975000
		///</summary>
		
		private long? distribute_end_time_;
		
		///<summary>
		/// 工单号  如此字段传值，则分发开始时间和结束时间字段可不用传，否则忽略
		/// @sampleValue work_order_no DH201812274412200
		///</summary>
		
		private string work_order_no_;
		
		public string GetCarrier_code(){
			return this.carrier_code_;
		}
		
		public void SetCarrier_code(string value){
			this.carrier_code_ = value;
		}
		public long? GetDistribute_start_time(){
			return this.distribute_start_time_;
		}
		
		public void SetDistribute_start_time(long? value){
			this.distribute_start_time_ = value;
		}
		public long? GetDistribute_end_time(){
			return this.distribute_end_time_;
		}
		
		public void SetDistribute_end_time(long? value){
			this.distribute_end_time_ = value;
		}
		public string GetWork_order_no(){
			return this.work_order_no_;
		}
		
		public void SetWork_order_no(string value){
			this.work_order_no_ = value;
		}
		
	}
	
}