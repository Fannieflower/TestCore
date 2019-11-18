using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.imp.otd.otdapi.service{
	
	
	
	
	
	public class VopPageModel {
		
		///<summary>
		/// 页码,从1开始, 默认1
		///</summary>
		
		private long? page_index_;
		
		///<summary>
		/// 每页数量, 默认20
		///</summary>
		
		private long? page_size_;
		
		///<summary>
		/// 总数量
		///</summary>
		
		private long? total_count_;
		
		public long? GetPage_index(){
			return this.page_index_;
		}
		
		public void SetPage_index(long? value){
			this.page_index_ = value;
		}
		public long? GetPage_size(){
			return this.page_size_;
		}
		
		public void SetPage_size(long? value){
			this.page_size_ = value;
		}
		public long? GetTotal_count(){
			return this.total_count_;
		}
		
		public void SetTotal_count(long? value){
			this.total_count_ = value;
		}
		
	}
	
}