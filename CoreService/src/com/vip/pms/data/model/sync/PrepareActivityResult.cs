using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.model.sync{
	
	
	
	
	
	public class PrepareActivityResult {
		
		///<summary>
		/// promotion object id
		///</summary>
		
		private long? promotionObjectId_;
		
		public long? GetPromotionObjectId(){
			return this.promotionObjectId_;
		}
		
		public void SetPromotionObjectId(long? value){
			this.promotionObjectId_ = value;
		}
		
	}
	
}