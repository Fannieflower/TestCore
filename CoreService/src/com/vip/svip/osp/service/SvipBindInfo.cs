using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class SvipBindInfo {
		
		///<summary>
		/// 卡类型
		///</summary>
		
		private int? type_;
		
		///<summary>
		/// 昵称
		///</summary>
		
		private string nick_name_;
		
		///<summary>
		/// 头像URL
		///</summary>
		
		private string figure_url_;
		
		///<summary>
		/// 绑定时间
		///</summary>
		
		private System.DateTime? bind_time_;
		
		public int? GetType(){
			return this.type_;
		}
		
		public void SetType(int? value){
			this.type_ = value;
		}
		public string GetNick_name(){
			return this.nick_name_;
		}
		
		public void SetNick_name(string value){
			this.nick_name_ = value;
		}
		public string GetFigure_url(){
			return this.figure_url_;
		}
		
		public void SetFigure_url(string value){
			this.figure_url_ = value;
		}
		public System.DateTime? GetBind_time(){
			return this.bind_time_;
		}
		
		public void SetBind_time(System.DateTime? value){
			this.bind_time_ = value;
		}
		
	}
	
}