using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.ap.service{
	
	
	
	public class BillAndDiscountDetailRealTimeReqItemHelper : TBeanSerializer<BillAndDiscountDetailRealTimeReqItem>
	{
		
		public static BillAndDiscountDetailRealTimeReqItemHelper OBJ = new BillAndDiscountDetailRealTimeReqItemHelper();
		
		public static BillAndDiscountDetailRealTimeReqItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BillAndDiscountDetailRealTimeReqItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("pager".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.fcs.ap.service.Pager value;
						
						value = new com.vip.fcs.ap.service.Pager();
						com.vip.fcs.ap.service.PagerHelper.getInstance().Read(value, iprot);
						
						structs.SetPager(value);
					}
					
					
					
					
					
					if ("vendorCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVendorCode(value);
					}
					
					
					
					
					
					if ("po".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPo(value);
					}
					
					
					
					
					
					if ("stQueryTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetStQueryTime(value);
					}
					
					
					
					
					
					if ("etQueryTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetEtQueryTime(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(BillAndDiscountDetailRealTimeReqItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPager() != null) {
				
				oprot.WriteFieldBegin("pager");
				
				com.vip.fcs.ap.service.PagerHelper.getInstance().Write(structs.GetPager(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVendorCode() != null) {
				
				oprot.WriteFieldBegin("vendorCode");
				oprot.WriteString(structs.GetVendorCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("vendorCode can not be null!");
			}
			
			
			if(structs.GetPo() != null) {
				
				oprot.WriteFieldBegin("po");
				oprot.WriteString(structs.GetPo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetStQueryTime() != null) {
				
				oprot.WriteFieldBegin("stQueryTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetStQueryTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("stQueryTime can not be null!");
			}
			
			
			if(structs.GetEtQueryTime() != null) {
				
				oprot.WriteFieldBegin("etQueryTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEtQueryTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("etQueryTime can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BillAndDiscountDetailRealTimeReqItem bean){
			
			
		}
		
	}
	
}