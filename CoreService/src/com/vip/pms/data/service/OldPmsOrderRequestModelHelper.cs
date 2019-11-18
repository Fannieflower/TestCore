using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class OldPmsOrderRequestModelHelper : TBeanSerializer<OldPmsOrderRequestModel>
	{
		
		public static OldPmsOrderRequestModelHelper OBJ = new OldPmsOrderRequestModelHelper();
		
		public static OldPmsOrderRequestModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(OldPmsOrderRequestModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("orderSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOrderSn(value);
					}
					
					
					
					
					
					if ("fav".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetFav(value);
					}
					
					
					
					
					
					if ("refIdType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetRefIdType(value);
					}
					
					
					
					
					
					if ("orderGoodsList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.pms.data.service.OldPmsOrderGoodsModel> value;
						
						value = new List<com.vip.pms.data.service.OldPmsOrderGoodsModel>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.pms.data.service.OldPmsOrderGoodsModel elem0;
								
								elem0 = new com.vip.pms.data.service.OldPmsOrderGoodsModel();
								com.vip.pms.data.service.OldPmsOrderGoodsModelHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetOrderGoodsList(value);
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
		
		
		public void Write(OldPmsOrderRequestModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetOrderSn() != null) {
				
				oprot.WriteFieldBegin("orderSn");
				oprot.WriteString(structs.GetOrderSn());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("orderSn can not be null!");
			}
			
			
			if(structs.GetFav() != null) {
				
				oprot.WriteFieldBegin("fav");
				oprot.WriteDouble((double)structs.GetFav());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("fav can not be null!");
			}
			
			
			if(structs.GetRefIdType() != null) {
				
				oprot.WriteFieldBegin("refIdType");
				oprot.WriteI32((int)structs.GetRefIdType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("refIdType can not be null!");
			}
			
			
			if(structs.GetOrderGoodsList() != null) {
				
				oprot.WriteFieldBegin("orderGoodsList");
				
				oprot.WriteListBegin();
				foreach(com.vip.pms.data.service.OldPmsOrderGoodsModel _item0 in structs.GetOrderGoodsList()){
					
					
					com.vip.pms.data.service.OldPmsOrderGoodsModelHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(OldPmsOrderRequestModel bean){
			
			
		}
		
	}
	
}