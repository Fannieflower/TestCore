using System;
using System.Collections.Generic;

namespace vipapis.fcs.ap.service{
	
	
	public interface VspVendorBillAndDiscountService {
		
		
		com.vip.fcs.ap.service.VendorDiscountDetailRespItem getBillDiscountDetailPage( com.vip.fcs.ap.service.BillAndDiscountDetailReqItem reqItem_,   string vendor_code_ );
		
		com.vip.fcs.ap.service.VendorDiscountSourceRespItem getBillDiscountSourcePage( com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem reqItem_,   string vendor_code_ );
		
		com.vip.fcs.ap.service.VendorBillDetailRespItem getBillGoodsDetailPage( com.vip.fcs.ap.service.BillAndDiscountDetailReqItem reqItem_,   string vendor_code_ );
		
		com.vip.fcs.ap.service.VendorBillSourceRespItem getBillGoodsSourcePage( com.vip.fcs.ap.service.BillAndDiscountDetailRealTimeReqItem reqItem_,   string vendor_code_ );
		
		com.vip.fcs.ap.service.InvTransDetailRespItem getInvTransDetailPage( com.vip.fcs.ap.service.InvTransDetailReqItem reqItem_,   string vendor_code_ );
		
		com.vip.hermes.core.health.CheckResult healthCheck();
		
	}
	
}