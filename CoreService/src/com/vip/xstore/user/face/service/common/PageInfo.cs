using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.user.face.service.common{
	
	
	
	
	
	public class PageInfo {
		
		///<summary>
		/// 当前页码
		///</summary>
		
		private int? pageIndex_;
		
		///<summary>
		/// 每页条数，默认10
		///</summary>
		
		private int? pageSize_;
		
		///<summary>
		/// 每页条数，默认0
		///</summary>
		
		private int? offset_;
		
		public int? GetPageIndex(){
			return this.pageIndex_;
		}
		
		public void SetPageIndex(int? value){
			this.pageIndex_ = value;
		}
		public int? GetPageSize(){
			return this.pageSize_;
		}
		
		public void SetPageSize(int? value){
			this.pageSize_ = value;
		}
		public int? GetOffset(){
			return this.offset_;
		}
		
		public void SetOffset(int? value){
			this.offset_ = value;
		}
		
	}
	
}