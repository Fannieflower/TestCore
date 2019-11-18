using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class GetSvipGoodsRequest {
		
		///<summary>
		/// 用户id
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 用户ip
		///</summary>
		
		private string userIp_;
		
		///<summary>
		/// tokenId
		///</summary>
		
		private string tokenId_;
		
		///<summary>
		/// tokenSecret
		///</summary>
		
		private string tokenSecret_;
		
		///<summary>
		/// 商品id
		///</summary>
		
		private string mid_;
		
		///<summary>
		/// 站点
		///</summary>
		
		private string warehouse_;
		
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
		public string GetTokenId(){
			return this.tokenId_;
		}
		
		public void SetTokenId(string value){
			this.tokenId_ = value;
		}
		public string GetTokenSecret(){
			return this.tokenSecret_;
		}
		
		public void SetTokenSecret(string value){
			this.tokenSecret_ = value;
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
		
	}
	
}