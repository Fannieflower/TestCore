using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class SvipUserOperateInfoParam {
		
		///<summary>
		/// 用户ID
		///</summary>
		
		private long? user_id_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_no_;
		
		///<summary>
		/// 商品ID
		///</summary>
		
		private long? product_id_;
		
		///<summary>
		/// 付费金额
		///</summary>
		
		private string money_;
		
		///<summary>
		/// 执行类型
		///</summary>
		
		private int? exec_type_;
		
		///<summary>
		/// 开通类型
		///</summary>
		
		private int? open_type_;
		
		///<summary>
		/// 开通天数
		///</summary>
		
		private int? days_;
		
		///<summary>
		/// 来源端
		///</summary>
		
		private string exec_source_;
		
		///<summary>
		/// 操作内容
		///</summary>
		
		private string exec_content_;
		
		///<summary>
		/// 操作人
		///</summary>
		
		private string operate_user_;
		
		///<summary>
		/// 流水唯一号码
		///</summary>
		
		private string unique_code_;
		
		///<summary>
		/// 扩展字段
		///</summary>
		
		private string extension_;
		
		///<summary>
		/// IP地址
		///</summary>
		
		private string ip_;
		
		///<summary>
		/// 来源平台
		///</summary>
		
		private string platform_;
		
		///<summary>
		/// 时间
		///</summary>
		
		private System.DateTime? dateTime_;
		
		public long? GetUser_id(){
			return this.user_id_;
		}
		
		public void SetUser_id(long? value){
			this.user_id_ = value;
		}
		public string GetOrder_no(){
			return this.order_no_;
		}
		
		public void SetOrder_no(string value){
			this.order_no_ = value;
		}
		public long? GetProduct_id(){
			return this.product_id_;
		}
		
		public void SetProduct_id(long? value){
			this.product_id_ = value;
		}
		public string GetMoney(){
			return this.money_;
		}
		
		public void SetMoney(string value){
			this.money_ = value;
		}
		public int? GetExec_type(){
			return this.exec_type_;
		}
		
		public void SetExec_type(int? value){
			this.exec_type_ = value;
		}
		public int? GetOpen_type(){
			return this.open_type_;
		}
		
		public void SetOpen_type(int? value){
			this.open_type_ = value;
		}
		public int? GetDays(){
			return this.days_;
		}
		
		public void SetDays(int? value){
			this.days_ = value;
		}
		public string GetExec_source(){
			return this.exec_source_;
		}
		
		public void SetExec_source(string value){
			this.exec_source_ = value;
		}
		public string GetExec_content(){
			return this.exec_content_;
		}
		
		public void SetExec_content(string value){
			this.exec_content_ = value;
		}
		public string GetOperate_user(){
			return this.operate_user_;
		}
		
		public void SetOperate_user(string value){
			this.operate_user_ = value;
		}
		public string GetUnique_code(){
			return this.unique_code_;
		}
		
		public void SetUnique_code(string value){
			this.unique_code_ = value;
		}
		public string GetExtension(){
			return this.extension_;
		}
		
		public void SetExtension(string value){
			this.extension_ = value;
		}
		public string GetIp(){
			return this.ip_;
		}
		
		public void SetIp(string value){
			this.ip_ = value;
		}
		public string GetPlatform(){
			return this.platform_;
		}
		
		public void SetPlatform(string value){
			this.platform_ = value;
		}
		public System.DateTime? GetDateTime(){
			return this.dateTime_;
		}
		
		public void SetDateTime(System.DateTime? value){
			this.dateTime_ = value;
		}
		
	}
	
}