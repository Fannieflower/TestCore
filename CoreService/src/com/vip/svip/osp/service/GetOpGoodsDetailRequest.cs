using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GetOpGoodsDetailRequest {
		
		///<summary>
		/// userId
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 用户ip
		///</summary>
		
		private string userIp_;
		
		///<summary>
		/// mid
		///</summary>
		
		private string mid_;
		
		///<summary>
		/// 站点
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 业务分组
		///</summary>
		
		private string bizType_;
		
		///<summary>
		/// 前置仓areaId
		///</summary>
		
		private string areaId_;
		
		///<summary>
		/// s商品id
		///</summary>
		
		private List<long?> ids_;
		
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public string GetUserIp(){
			return this.userIp_;
		}
		
		public void SetUserIp(string value){
			this.userIp_ = value;
		}
		public string GetMid(){
			return this.mid_;
		}
		
		public void SetMid(string value){
			this.mid_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public string GetBizType(){
			return this.bizType_;
		}
		
		public void SetBizType(string value){
			this.bizType_ = value;
		}
		public string GetAreaId(){
			return this.areaId_;
		}
		
		public void SetAreaId(string value){
			this.areaId_ = value;
		}
		public List<long?> GetIds(){
			return this.ids_;
		}
		
		public void SetIds(List<long?> value){
			this.ids_ = value;
		}
		
	}
	
}