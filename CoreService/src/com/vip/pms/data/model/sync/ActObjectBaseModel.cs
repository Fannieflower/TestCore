using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.model.sync{
	
	
	
	
	
	public class ActObjectBaseModel {
		
		///<summary>
		/// promotion object id
		///</summary>
		
		private long? objectId_;
		
		///<summary>
		/// 分页ID，用于判断是否重复提交
		///</summary>
		
		private int? pageId_;
		
		///<summary>
		/// 1:买赠 2:满减 3:折扣 4:免邮 5:换购 6:买免 7:自由赠 8:虚拟买赠 9:搭配优惠 10:唯品币 11:预付 12: N元任选  19:分享优惠
		///</summary>
		
		private int? actType_;
		
		///<summary>
		/// 活动名称
		///</summary>
		
		private string actName_;
		
		///<summary>
		/// 子活动号，单品直降活动必传，用于关联promotion_object_goods表的商品信息
		///</summary>
		
		private string actNo_;
		
		///<summary>
		/// 活动主编号
		///</summary>
		
		private string actMainNo_;
		
		public long? GetObjectId(){
			return this.objectId_;
		}
		
		public void SetObjectId(long? value){
			this.objectId_ = value;
		}
		public int? GetPageId(){
			return this.pageId_;
		}
		
		public void SetPageId(int? value){
			this.pageId_ = value;
		}
		public int? GetActType(){
			return this.actType_;
		}
		
		public void SetActType(int? value){
			this.actType_ = value;
		}
		public string GetActName(){
			return this.actName_;
		}
		
		public void SetActName(string value){
			this.actName_ = value;
		}
		public string GetActNo(){
			return this.actNo_;
		}
		
		public void SetActNo(string value){
			this.actNo_ = value;
		}
		public string GetActMainNo(){
			return this.actMainNo_;
		}
		
		public void SetActMainNo(string value){
			this.actMainNo_ = value;
		}
		
	}
	
}