using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.price{
	
	
	
	public class PricingReceiptReqHelper : TBeanSerializer<PricingReceiptReq>
	{
		
		public static PricingReceiptReqHelper OBJ = new PricingReceiptReqHelper();
		
		public static PricingReceiptReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PricingReceiptReq structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("reqContext".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.xstore.cc.price.ReqContext value;
						
						value = new com.vip.xstore.cc.price.ReqContext();
						com.vip.xstore.cc.price.ReqContextHelper.getInstance().Read(value, iprot);
						
						structs.SetReqContext(value);
					}
					
					
					
					
					
					if ("page".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPage(value);
					}
					
					
					
					
					
					if ("pageSize".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPageSize(value);
					}
					
					
					
					
					
					if ("startCreateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetStartCreateTime(value);
					}
					
					
					
					
					
					if ("endCreateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetEndCreateTime(value);
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
		
		
		public void Write(PricingReceiptReq structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetReqContext() != null) {
				
				oprot.WriteFieldBegin("reqContext");
				
				com.vip.xstore.cc.price.ReqContextHelper.getInstance().Write(structs.GetReqContext(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("reqContext can not be null!");
			}
			
			
			if(structs.GetPage() != null) {
				
				oprot.WriteFieldBegin("page");
				oprot.WriteI32((int)structs.GetPage()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("page can not be null!");
			}
			
			
			if(structs.GetPageSize() != null) {
				
				oprot.WriteFieldBegin("pageSize");
				oprot.WriteI32((int)structs.GetPageSize()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pageSize can not be null!");
			}
			
			
			if(structs.GetStartCreateTime() != null) {
				
				oprot.WriteFieldBegin("startCreateTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetStartCreateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("startCreateTime can not be null!");
			}
			
			
			if(structs.GetEndCreateTime() != null) {
				
				oprot.WriteFieldBegin("endCreateTime");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetEndCreateTime())); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("endCreateTime can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PricingReceiptReq bean){
			
			
		}
		
	}
	
}