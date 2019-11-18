using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.cc.bulkbuying.model{
	
	
	
	
	
	public class PaginationModel {
		
		///<summary>
		/// 总条数
		///</summary>
		
		private long? totalCounts_;
		
		///<summary>
		/// 总页数
		///</summary>
		
		private int? totalPages_;
		
		///<summary>
		/// 是否有上一页
		///</summary>
		
		private bool? hasPrevs_;
		
		///<summary>
		/// 是否有下一页
		///</summary>
		
		private bool? hasNext_;
		
		public long? GetTotalCounts(){
			return this.totalCounts_;
		}
		
		public void SetTotalCounts(long? value){
			this.totalCounts_ = value;
		}
		public int? GetTotalPages(){
			return this.totalPages_;
		}
		
		public void SetTotalPages(int? value){
			this.totalPages_ = value;
		}
		public bool? GetHasPrevs(){
			return this.hasPrevs_;
		}
		
		public void SetHasPrevs(bool? value){
			this.hasPrevs_ = value;
		}
		public bool? GetHasNext(){
			return this.hasNext_;
		}
		
		public void SetHasNext(bool? value){
			this.hasNext_ = value;
		}
		
	}
	
}