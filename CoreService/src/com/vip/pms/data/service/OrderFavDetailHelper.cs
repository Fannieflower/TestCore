using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class OrderFavDetailHelper : TBeanSerializer<OrderFavDetail>
	{
		
		public static OrderFavDetailHelper OBJ = new OrderFavDetailHelper();
		
		public static OrderFavDetailHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OrderFavDetail structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("sizeId".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSizeId(value);
					}
					
					
					
					
					
					if ("goodsNumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetGoodsNumber(value);
					}
					
					
					
					
					
					if ("favAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetFavAmount(value);
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
		
		
		public void Write(OrderFavDetail structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSizeId() != null) {
				
				oprot.WriteFieldBegin("sizeId");
				oprot.WriteString(structs.GetSizeId());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("sizeId can not be null!");
			}
			
			
			if(structs.GetGoodsNumber() != null) {
				
				oprot.WriteFieldBegin("goodsNumber");
				oprot.WriteI32((int)structs.GetGoodsNumber()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("goodsNumber can not be null!");
			}
			
			
			if(structs.GetFavAmount() != null) {
				
				oprot.WriteFieldBegin("favAmount");
				oprot.WriteDouble((double)structs.GetFavAmount());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("favAmount can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OrderFavDetail bean){
			
			
		}
		
	}
	
}