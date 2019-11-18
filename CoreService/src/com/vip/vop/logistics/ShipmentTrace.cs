using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics{
	
	
	
	
	
	public class ShipmentTrace {
		
		///<summary>
		/// 承运商轨迹编码
		/// @sampleValue trace_code 
		///</summary>
		
		private string trace_code_;
		
		///<summary>
		/// ACCEPT=揽收、TRANSIT=运输、DELIVERY=派送、RECEIVER_ACCEPT=面签、THIRD_PARTY_ACCEPT=第三方签收、REFUND_ACCEPT=退件签收、RECEIVER_REJECT=拒收
		/// @sampleValue action TRANSIT
		///</summary>
		
		private string action_;
		
		///<summary>
		/// 到达芳村配送站点
		/// @sampleValue remark 
		///</summary>
		
		private string remark_;
		
		///<summary>
		/// 操作时间
		/// @sampleValue op_time 2000-01-01 00:00:00
		///</summary>
		
		private System.DateTime? op_time_;
		
		///<summary>
		/// 当前站点城市名称
		/// @sampleValue city_name 广州市
		///</summary>
		
		private string city_name_;
		
		///<summary>
		/// 当前站点编码
		/// @sampleValue site_code 00001
		///</summary>
		
		private string site_code_;
		
		///<summary>
		/// 当前站点名称
		/// @sampleValue site_name 荔湾调拨站
		///</summary>
		
		private string site_name_;
		
		///<summary>
		/// 操作人名称
		/// @sampleValue operator 张三
		///</summary>
		
		private string operator_;
		
		///<summary>
		/// 操作人电话
		/// @sampleValue operator_tel 020-1002343
		///</summary>
		
		private string operator_tel_;
		
		///<summary>
		/// 下一站城市名
		/// @sampleValue next_city_name 上海市
		///</summary>
		
		private string next_city_name_;
		
		///<summary>
		/// 下一站站点编码
		/// @sampleValue next_site_code 00002
		///</summary>
		
		private string next_site_code_;
		
		///<summary>
		/// 下一站站点名称
		/// @sampleValue next_site_name 上海调拨站
		///</summary>
		
		private string next_site_name_;
		
		///<summary>
		/// 扩展字段列表，sign_by表示签收人
		/// @sampleValue extend_fields 
		///</summary>
		
		private List<com.vip.vop.logistics.ExtendField> extend_fields_;
		
		public string GetTrace_code(){
			return this.trace_code_;
		}
		
		public void SetTrace_code(string value){
			this.trace_code_ = value;
		}
		public string GetAction(){
			return this.action_;
		}
		
		public void SetAction(string value){
			this.action_ = value;
		}
		public string GetRemark(){
			return this.remark_;
		}
		
		public void SetRemark(string value){
			this.remark_ = value;
		}
		public System.DateTime? GetOp_time(){
			return this.op_time_;
		}
		
		public void SetOp_time(System.DateTime? value){
			this.op_time_ = value;
		}
		public string GetCity_name(){
			return this.city_name_;
		}
		
		public void SetCity_name(string value){
			this.city_name_ = value;
		}
		public string GetSite_code(){
			return this.site_code_;
		}
		
		public void SetSite_code(string value){
			this.site_code_ = value;
		}
		public string GetSite_name(){
			return this.site_name_;
		}
		
		public void SetSite_name(string value){
			this.site_name_ = value;
		}
		public string GetOperator(){
			return this.operator_;
		}
		
		public void SetOperator(string value){
			this.operator_ = value;
		}
		public string GetOperator_tel(){
			return this.operator_tel_;
		}
		
		public void SetOperator_tel(string value){
			this.operator_tel_ = value;
		}
		public string GetNext_city_name(){
			return this.next_city_name_;
		}
		
		public void SetNext_city_name(string value){
			this.next_city_name_ = value;
		}
		public string GetNext_site_code(){
			return this.next_site_code_;
		}
		
		public void SetNext_site_code(string value){
			this.next_site_code_ = value;
		}
		public string GetNext_site_name(){
			return this.next_site_name_;
		}
		
		public void SetNext_site_name(string value){
			this.next_site_name_ = value;
		}
		public List<com.vip.vop.logistics.ExtendField> GetExtend_fields(){
			return this.extend_fields_;
		}
		
		public void SetExtend_fields(List<com.vip.vop.logistics.ExtendField> value){
			this.extend_fields_ = value;
		}
		
	}
	
}