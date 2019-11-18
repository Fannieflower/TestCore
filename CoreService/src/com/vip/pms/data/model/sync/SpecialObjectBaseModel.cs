using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.model.sync{
	
	
	
	
	
	public class SpecialObjectBaseModel {
		
		///<summary>
		/// promotion object id
		///</summary>
		
		private long? objectId_;
		
		///<summary>
		/// 分页ID，用于判断是否重复提交
		///</summary>
		
		private int? pageId_;
		
		///<summary>
		/// 优惠类型 2立减 3折扣
		///</summary>
		
		private int? actType_;
		
		///<summary>
		/// 活动名称
		///</summary>
		
		private string actName_;
		
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
		
	}
	
}