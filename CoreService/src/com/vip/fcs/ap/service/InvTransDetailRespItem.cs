using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.ap.service{
	
	
	
	
	
	public class InvTransDetailRespItem {
		
		///<summary>
		/// 状态码
		///</summary>
		
		private int? code_;
		
		///<summary>
		/// 返回信息
		///</summary>
		
		private string msg_;
		
		///<summary>
		/// 总数据量
		///</summary>
		
		private long? count_;
		
		///<summary>
		/// 请求参数对象
		///</summary>
		
		private com.vip.fcs.ap.service.InvTransDetailReqItem invTransDetailReqItem_;
		
		///<summary>
		/// 收发存详情数据结果集
		///</summary>
		
		private List<com.vip.fcs.ap.service.InvTransDetail> invTransDetails_;
		
		public int? GetCode(){
			return this.code_;
		}
		
		public void SetCode(int? value){
			this.code_ = value;
		}
		public string GetMsg(){
			return this.msg_;
		}
		
		public void SetMsg(string value){
			this.msg_ = value;
		}
		public long? GetCount(){
			return this.count_;
		}
		
		public void SetCount(long? value){
			this.count_ = value;
		}
		public com.vip.fcs.ap.service.InvTransDetailReqItem GetInvTransDetailReqItem(){
			return this.invTransDetailReqItem_;
		}
		
		public void SetInvTransDetailReqItem(com.vip.fcs.ap.service.InvTransDetailReqItem value){
			this.invTransDetailReqItem_ = value;
		}
		public List<com.vip.fcs.ap.service.InvTransDetail> GetInvTransDetails(){
			return this.invTransDetails_;
		}
		
		public void SetInvTransDetails(List<com.vip.fcs.ap.service.InvTransDetail> value){
			this.invTransDetails_ = value;
		}
		
	}
	
}