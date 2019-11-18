using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class SvipTXBindHistoryResult {
		
		///<summary>
		/// 用户ID
		///</summary>
		
		private long? user_id_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_no_;
		
		///<summary>
		/// 帐号类型
		///</summary>
		
		private int? tencent_acct_type_;
		
		///<summary>
		/// 腾讯侧开卡类型类型
		///</summary>
		
		private int? tencent_member_type_;
		
		///<summary>
		/// 腾讯帐号
		///</summary>
		
		private string tencent_acct_;
		
		///<summary>
		/// 开通时间
		///</summary>
		
		private System.DateTime? create_time_;
		
		///<summary>
		/// 腾讯昵称
		///</summary>
		
		private string tx_nick_name_;
		
		///<summary>
		/// 腾讯昵称头像
		///</summary>
		
		private string tx_figure_url_;
		
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
		public int? GetTencent_acct_type(){
			return this.tencent_acct_type_;
		}
		
		public void SetTencent_acct_type(int? value){
			this.tencent_acct_type_ = value;
		}
		public int? GetTencent_member_type(){
			return this.tencent_member_type_;
		}
		
		public void SetTencent_member_type(int? value){
			this.tencent_member_type_ = value;
		}
		public string GetTencent_acct(){
			return this.tencent_acct_;
		}
		
		public void SetTencent_acct(string value){
			this.tencent_acct_ = value;
		}
		public System.DateTime? GetCreate_time(){
			return this.create_time_;
		}
		
		public void SetCreate_time(System.DateTime? value){
			this.create_time_ = value;
		}
		public string GetTx_nick_name(){
			return this.tx_nick_name_;
		}
		
		public void SetTx_nick_name(string value){
			this.tx_nick_name_ = value;
		}
		public string GetTx_figure_url(){
			return this.tx_figure_url_;
		}
		
		public void SetTx_figure_url(string value){
			this.tx_figure_url_ = value;
		}
		
	}
	
}