using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics.cabinet{
	
	
	
	
	
	public class ShipmentTrace {
		
		///<summary>
		/// 承运商轨迹编码
		/// @sampleValue trace_code 
		///</summary>
		
		private string trace_code_;
		
		///<summary>
		/// POSTMAN_PUT=快递员投递入柜,<br>RECEIVER_TAKE=收件人取走快件,<br>POSTMAN_TAKE=快递员取回快件,<br>POSTMAN_CANCEL_DELIVERY=快递员取消派件,<br>ADMIN_TAKE=快递柜管理员取出快件暂存
		/// @sampleValue action POSTMAN_PUT
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
		/// 快递柜编码
		/// @sampleValue express_cabinet_code A-001
		///</summary>
		
		private string express_cabinet_code_;
		
		///<summary>
		/// 快递柜名称
		/// @sampleValue express_cabinet_name 唯品会广新丰巢柜
		///</summary>
		
		private string express_cabinet_name_;
		
		///<summary>
		/// 快递柜地址
		///</summary>
		
		private com.vip.vop.logistics.Address address_;
		
		///<summary>
		/// 经度
		/// @sampleValue longitude 116.407413
		///</summary>
		
		private string longitude_;
		
		///<summary>
		/// 纬度
		/// @sampleValue latitude 39.904214
		///</summary>
		
		private string latitude_;
		
		///<summary>
		/// 联系人名称
		/// @sampleValue linkman 张三
		///</summary>
		
		private string linkman_;
		
		///<summary>
		/// 联系人电话
		/// @sampleValue linkman_tel 13800000000
		///</summary>
		
		private string linkman_tel_;
		
		///<summary>
		/// 扩展字段列表
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
		public string GetExpress_cabinet_code(){
			return this.express_cabinet_code_;
		}
		
		public void SetExpress_cabinet_code(string value){
			this.express_cabinet_code_ = value;
		}
		public string GetExpress_cabinet_name(){
			return this.express_cabinet_name_;
		}
		
		public void SetExpress_cabinet_name(string value){
			this.express_cabinet_name_ = value;
		}
		public com.vip.vop.logistics.Address GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(com.vip.vop.logistics.Address value){
			this.address_ = value;
		}
		public string GetLongitude(){
			return this.longitude_;
		}
		
		public void SetLongitude(string value){
			this.longitude_ = value;
		}
		public string GetLatitude(){
			return this.latitude_;
		}
		
		public void SetLatitude(string value){
			this.latitude_ = value;
		}
		public string GetLinkman(){
			return this.linkman_;
		}
		
		public void SetLinkman(string value){
			this.linkman_ = value;
		}
		public string GetLinkman_tel(){
			return this.linkman_tel_;
		}
		
		public void SetLinkman_tel(string value){
			this.linkman_tel_ = value;
		}
		public List<com.vip.vop.logistics.ExtendField> GetExtend_fields(){
			return this.extend_fields_;
		}
		
		public void SetExtend_fields(List<com.vip.vop.logistics.ExtendField> value){
			this.extend_fields_ = value;
		}
		
	}
	
}