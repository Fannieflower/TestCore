using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class SearchSvipHistoryResult {
		
		///<summary>
		/// 用户ID
		///</summary>
		
		private long? user_id_;
		
		///<summary>
		/// 用户当时开通的等级
		///</summary>
		
		private string level_;
		
		///<summary>
		/// 用户操作类型
		///</summary>
		
		private int? exec_type_;
		
		///<summary>
		/// 用户开通渠道
		///</summary>
		
		private string exec_source_;
		
		///<summary>
		/// 操作的内容
		///</summary>
		
		private string exec_content_;
		
		///<summary>
		/// 后返信息
		///</summary>
		
		private string gift_;
		
		///<summary>
		/// 权益开始时间
		///</summary>
		
		private System.DateTime? start_time_;
		
		///<summary>
		/// 权益结束时间
		///</summary>
		
		private System.DateTime? end_time_;
		
		///<summary>
		/// 操作人
		///</summary>
		
		private string operate_user_;
		
		///<summary>
		/// 套餐钱
		///</summary>
		
		private string money_;
		
		///<summary>
		/// 操作时间
		///</summary>
		
		private System.DateTime? create_time_;
		
		///<summary>
		/// 操作更新时间
		///</summary>
		
		private System.DateTime? update_time_;
		
		///<summary>
		/// 套餐开通类型
		///</summary>
		
		private int? open_type_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_no_;
		
		public long? GetUser_id(){
			return this.user_id_;
		}
		
		public void SetUser_id(long? value){
			this.user_id_ = value;
		}
		public string GetLevel(){
			return this.level_;
		}
		
		public void SetLevel(string value){
			this.level_ = value;
		}
		public int? GetExec_type(){
			return this.exec_type_;
		}
		
		public void SetExec_type(int? value){
			this.exec_type_ = value;
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
		public string GetGift(){
			return this.gift_;
		}
		
		public void SetGift(string value){
			this.gift_ = value;
		}
		public System.DateTime? GetStart_time(){
			return this.start_time_;
		}
		
		public void SetStart_time(System.DateTime? value){
			this.start_time_ = value;
		}
		public System.DateTime? GetEnd_time(){
			return this.end_time_;
		}
		
		public void SetEnd_time(System.DateTime? value){
			this.end_time_ = value;
		}
		public string GetOperate_user(){
			return this.operate_user_;
		}
		
		public void SetOperate_user(string value){
			this.operate_user_ = value;
		}
		public string GetMoney(){
			return this.money_;
		}
		
		public void SetMoney(string value){
			this.money_ = value;
		}
		public System.DateTime? GetCreate_time(){
			return this.create_time_;
		}
		
		public void SetCreate_time(System.DateTime? value){
			this.create_time_ = value;
		}
		public System.DateTime? GetUpdate_time(){
			return this.update_time_;
		}
		
		public void SetUpdate_time(System.DateTime? value){
			this.update_time_ = value;
		}
		public int? GetOpen_type(){
			return this.open_type_;
		}
		
		public void SetOpen_type(int? value){
			this.open_type_ = value;
		}
		public string GetOrder_no(){
			return this.order_no_;
		}
		
		public void SetOrder_no(string value){
			this.order_no_ = value;
		}
		
	}
	
}