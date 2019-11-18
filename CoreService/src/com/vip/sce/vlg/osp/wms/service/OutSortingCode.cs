using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.sce.vlg.osp.wms.service{
	
	
	
	
	
	public class OutSortingCode {
		
		///<summary>
		/// 流水号
		///</summary>
		
		private string messageId_;
		
		///<summary>
		/// 包裹号
		///</summary>
		
		private string containerCode_;
		
		///<summary>
		/// 分拣码
		///</summary>
		
		private string pickCode_;
		
		///<summary>
		/// 承运商信息
		///</summary>
		
		private string carriersCode_;
		
		///<summary>
		/// 扩展字段1
		///</summary>
		
		private string userDefined1_;
		
		///<summary>
		/// 扩展字段2
		///</summary>
		
		private string userDefined2_;
		
		///<summary>
		/// 扩展字段3
		///</summary>
		
		private string userDefined3_;
		
		///<summary>
		/// 扩展字段4
		///</summary>
		
		private string userDefined4_;
		
		///<summary>
		/// 扩展字段5
		///</summary>
		
		private string userDefined5_;
		
		public string GetMessageId(){
			return this.messageId_;
		}
		
		public void SetMessageId(string value){
			this.messageId_ = value;
		}
		public string GetContainerCode(){
			return this.containerCode_;
		}
		
		public void SetContainerCode(string value){
			this.containerCode_ = value;
		}
		public string GetPickCode(){
			return this.pickCode_;
		}
		
		public void SetPickCode(string value){
			this.pickCode_ = value;
		}
		public string GetCarriersCode(){
			return this.carriersCode_;
		}
		
		public void SetCarriersCode(string value){
			this.carriersCode_ = value;
		}
		public string GetUserDefined1(){
			return this.userDefined1_;
		}
		
		public void SetUserDefined1(string value){
			this.userDefined1_ = value;
		}
		public string GetUserDefined2(){
			return this.userDefined2_;
		}
		
		public void SetUserDefined2(string value){
			this.userDefined2_ = value;
		}
		public string GetUserDefined3(){
			return this.userDefined3_;
		}
		
		public void SetUserDefined3(string value){
			this.userDefined3_ = value;
		}
		public string GetUserDefined4(){
			return this.userDefined4_;
		}
		
		public void SetUserDefined4(string value){
			this.userDefined4_ = value;
		}
		public string GetUserDefined5(){
			return this.userDefined5_;
		}
		
		public void SetUserDefined5(string value){
			this.userDefined5_ = value;
		}
		
	}
	
}