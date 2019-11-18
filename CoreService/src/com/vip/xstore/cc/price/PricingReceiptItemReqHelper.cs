using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.price{
	
	
	
	public class PricingReceiptItemReqHelper : TBeanSerializer<PricingReceiptItemReq>
	{
		
		public static PricingReceiptItemReqHelper OBJ = new PricingReceiptItemReqHelper();
		
		public static PricingReceiptItemReqHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PricingReceiptItemReq structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("pricingNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPricingNo(value);
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
		
		
		public void Write(PricingReceiptItemReq structs, Protocol oprot){
			
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
			
			
			if(structs.GetPricingNo() != null) {
				
				oprot.WriteFieldBegin("pricingNo");
				oprot.WriteString(structs.GetPricingNo());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pricingNo can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PricingReceiptItemReq bean){
			
			
		}
		
	}
	
}