using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.common{
	
	
	
	
	
	public class Pager {
		
		///<summary>
		/// 页码，从1开始，默认1
		/// @sampleValue page 1
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每次获取记录数，默认20
		/// @sampleValue size 20
		///</summary>
		
		private int? size_;
		
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetSize(){
			return this.size_;
		}
		
		public void SetSize(int? value){
			this.size_ = value;
		}
		
	}
	
}