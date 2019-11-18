using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.svip.osp.service{
	
	
	
	
	
	public class BaseRequestHeader {
		
		///<summary>
		/// 用户id
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// tokenId
		///</summary>
		
		private string tokenId_;
		
		///<summary>
		/// tokenSecret
		///</summary>
		
		private string tokenSecret_;
		
		///<summary>
		/// 用户ip
		///</summary>
		
		private string ip_;
		
		///<summary>
		/// 用户marsCid
		///</summary>
		
		private string marsCid_;
		
		///<summary>
		/// 是否需要节省金额信息(默认true)
		///</summary>
		
		private bool? needSaveAmount_;
		
		///<summary>
		/// 是否需要头像信息 (默认true)
		///</summary>
		
		private bool? needFigureUrl_;
		
		///<summary>
		/// 是否需要后返信息 (默认true)
		///</summary>
		
		private bool? needRebate_;
		
		///<summary>
		/// 是否需要SVIP价格信息 (默认true)
		///</summary>
		
		private bool? needPrice_;
		
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
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
		public string GetIp(){
			return this.ip_;
		}
		
		public void SetIp(string value){
			this.ip_ = value;
		}
		public string GetMarsCid(){
			return this.marsCid_;
		}
		
		public void SetMarsCid(string value){
			this.marsCid_ = value;
		}
		public bool? GetNeedSaveAmount(){
			return this.needSaveAmount_;
		}
		
		public void SetNeedSaveAmount(bool? value){
			this.needSaveAmount_ = value;
		}
		public bool? GetNeedFigureUrl(){
			return this.needFigureUrl_;
		}
		
		public void SetNeedFigureUrl(bool? value){
			this.needFigureUrl_ = value;
		}
		public bool? GetNeedRebate(){
			return this.needRebate_;
		}
		
		public void SetNeedRebate(bool? value){
			this.needRebate_ = value;
		}
		public bool? GetNeedPrice(){
			return this.needPrice_;
		}
		
		public void SetNeedPrice(bool? value){
			this.needPrice_ = value;
		}
		
	}
	
}