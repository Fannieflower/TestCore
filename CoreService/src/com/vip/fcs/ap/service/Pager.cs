using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.ap.service{
	
	
	
	
	
	public class Pager {
		
		///<summary>
		/// 页码,默认为1，page =总记录数/ page_size 取整加1
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每次获取记录数，默认100，最大1000
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