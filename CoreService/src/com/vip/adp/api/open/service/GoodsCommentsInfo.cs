using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.adp.api.open.service{
	
	
	
	
	
	public class GoodsCommentsInfo {
		
		///<summary>
		/// 商品评论数
		///</summary>
		
		private int? comments_;
		
		///<summary>
		/// 商品好评率:百分比，不带百分号
		///</summary>
		
		private string goodCommentsShare_;
		
		public int? GetComments(){
			return this.comments_;
		}
		
		public void SetComments(int? value){
			this.comments_ = value;
		}
		public string GetGoodCommentsShare(){
			return this.goodCommentsShare_;
		}
		
		public void SetGoodCommentsShare(string value){
			this.goodCommentsShare_ = value;
		}
		
	}
	
}